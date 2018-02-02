using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAM.Core.DataProcessing;
using SAM.HPCncForm.Classes;
using ZedGraph;

namespace SAM.HPCncForm.DataProcessing
{
    public partial class AScanForm : Form
    {
        public AScanForm()
        {
            InitializeComponent();
        }

        private Thread loadDataThread;


        private const int shrinkFactor = 2;
        private Stopwatch mainsw = new Stopwatch();
        private void buttonStart_Click(object sender, EventArgs e)
        {
            mainsw.Restart();
            timerMainLoop.Enabled = !(timerMainLoop.Enabled);
            count = 0;
            configurePictureBox(pictureBoxGate1);
            configurePictureBox(pictureBoxGate2);
            configurePictureBox(pictureBoxGate3);

            var myPane = graphAScan.GraphPane;
            myPane.Title.Text = "A SCAN";
            myPane.YAxis.Title.Text = "Amplitude(V)";
            myPane.XAxis.Title.Text = "Sample";

            myPane.XAxis.Scale.MajorStep = 50;
            myPane.YAxis.Scale.MajorStep = 0.1;
            myPane.XAxis.Scale.Max = 200;
            myPane.XAxis.Scale.Min = 0;
            waitLoadingData();
            loadNewBscan();
        }

        private void configurePictureBox(PictureBox pictureBox)
        {
            pictureBox.Width = NUMBER_OF_RECORDS / shrinkFactor;
            pictureBox.Height = NUMBER_OF_BSCAN / shrinkFactor;
            pictureBox.Image = new Bitmap(NUMBER_OF_RECORDS / shrinkFactor, NUMBER_OF_BSCAN / shrinkFactor);
        }

        private void loadNewBscan()
        {
            loadDataThread = new Thread(loadCurrentBscan);
            loadDataThread.Start();
        }

        private void waitLoadingData()
        {
            if (loadDataThread != null)
                loadDataThread.Join();
        }

        private float[,] currentBScan;
        private void loadCurrentBscan()
        {
            count += shrinkFactor;
            var path = string.Format(@"D:\CurrentWork\Data\29e79\e79\29e79_{0}.dat", count);
            currentBScan = SamBScanLoader.LoadFloat(path, NUMBER_OF_RECORDS, RECORD_LENGTH);
        }

        private static double[] createSamplesArray(int dataLength)
        {
            var samples = new double[dataLength];
            for (int i = 0; i < dataLength; i++)
            {
                samples[i] = i;
            }
            return samples;
        }

        private int count;
        private const int RECORD_LENGTH = 150;
        private const int NUMBER_OF_RECORDS = 1400;
        private const int NUMBER_OF_BSCAN = 550;
        private PointPairList gate1;
        private PointPairList gate2;

        private void timerMainLoop_Tick(object sender, EventArgs e)
        {
            if (count >= NUMBER_OF_BSCAN) 
            {
                mainsw.Stop();
                new Thread(()=>MessageBox.Show("Total time: " + mainsw.Elapsed.TotalSeconds)).Start();
                timerMainLoop.Enabled = false;
                return;
            }

            waitLoadingData();
            var floatBscan = new float[NUMBER_OF_RECORDS,RECORD_LENGTH];
            for (int i = 0; i < NUMBER_OF_RECORDS; i++)
            {
                for (int j = 0; j < RECORD_LENGTH; j++)
                {
                    floatBscan[i, j] = currentBScan[i, j];
                }
            }

            loadNewBscan();

            var pixels = new byte[NUMBER_OF_RECORDS/shrinkFactor];
            var pixels1 = new byte[NUMBER_OF_RECORDS/shrinkFactor];
            var pixels2 = new byte[NUMBER_OF_RECORDS/shrinkFactor];
            Parallel.For(0, NUMBER_OF_RECORDS / shrinkFactor, col =>
            {
                {
                    var ascan = new double[RECORD_LENGTH];
                    for (int i = 0; i < RECORD_LENGTH; i++)
                        ascan[i] = floatBscan[col * shrinkFactor, i];

                    double peak;
                    var peakIndex = 0;
                    calculateHilbert(RECORD_LENGTH, ascan, out peak, out peakIndex);

                    var ascan1 = new double[scanGate1.RecordLength];
                    for (int i = 0; i < scanGate1.RecordLength; i++)
                    {
                        var idx = i + scanGate1.Offset + peakIndex;
                        idx = Math.Min(RECORD_LENGTH - 1, idx);
                        ascan1[i] = floatBscan[col*shrinkFactor, idx];
                    }

                    var ascan2 = new double[scanGate2.RecordLength];
                    for (int i = 0; i < scanGate2.RecordLength; i++)
                    {
                        var idx = i + scanGate2.Offset + peakIndex;
                        idx = Math.Min(RECORD_LENGTH - 1, idx);
                        ascan2[i] = floatBscan[col * shrinkFactor, idx];
                    }

                    var pixelVal = convertToByteWithRange(peak, 0, 0.8);
                    pixels[col] = pixelVal;

                    calculateHilbert(scanGate1.RecordLength, ascan1, out peak, out peakIndex);
                    pixelVal = convertToByteWithRange(peak, 0, scanGate1.MaxAmp);
                    pixels1[col] = pixelVal;

                    calculateHilbert(scanGate2.RecordLength, ascan2, out peak, out peakIndex);
                    pixelVal = convertToByteWithRange(peak, 0, scanGate2.MaxAmp);
                    pixels2[col] = pixelVal;
                }
            });

 
            var samples = createSamplesArray(RECORD_LENGTH);
            var myPane = graphAScan.GraphPane;
            myPane.CurveList.Clear();
            var ascanForDisplay = new double[RECORD_LENGTH];
            for (int i = 0; i < RECORD_LENGTH; i++)
                ascanForDisplay[i] = floatBscan[NUMBER_OF_RECORDS - 2, i];

            double presentPeak;
            int presentPeakIndex;
            calculateHilbert(RECORD_LENGTH, ascanForDisplay, out presentPeak, out presentPeakIndex);
            updateGate1(scanGate1, presentPeakIndex);
            updateGate2(scanGate2, presentPeakIndex);
            var aScanSignal = new PointPairList(samples, ascanForDisplay);
            myPane.AddCurve("A Scan", aScanSignal, Color.Blue, SymbolType.None);
            myPane.AddCurve("Gate 1", gate1, Color.Green, SymbolType.None);
            myPane.AddCurve("Gate 2", gate2, Color.Maroon, SymbolType.None);
            graphAScan.AxisChange();

            for (int i = 0; i < NUMBER_OF_RECORDS / shrinkFactor; i++)
            {
                var x = Math.Min(i, pictureBoxGate1.Width - 1);
                var y = Math.Min((count - 1)/shrinkFactor, pictureBoxGate1.Height - 1);
                var pixelVal = pixels[i];
                var pixelVal1 = pixels1[i];
                var pixelVal2 = pixels2[i];
                ((Bitmap)pictureBoxGate1.Image).SetPixel(x, y, Color.FromArgb(pixelVal, pixelVal, pixelVal));
                ((Bitmap)pictureBoxGate2.Image).SetPixel(x, y, Color.FromArgb(pixelVal1, pixelVal1, pixelVal1));
                ((Bitmap)pictureBoxGate3.Image).SetPixel(x, y, Color.FromArgb(pixelVal2, pixelVal2, pixelVal2));
            }

            Refresh();
        }

        private byte convertToByteWithRange(double input, double minimum, double maximum)
        {
            var unit = (maximum - minimum) / 256;
            var val = (input - minimum) / unit;
            val = Math.Max(byte.MinValue, val);
            val = Math.Min(val, byte.MaxValue);
            return (byte)val;
        }

        private static double[] calculateHilbert(int dataLength, double[] dblAScan, out double peak, out int peakIndex)
        {
            var complexSignal = createComplexArray(dataLength, dblAScan);
            return DIP.FastHT(complexSignal, FourierTransform.Direction.Forward, out peak, out peakIndex);
        }

        private static Complex[] createComplexArray(int dataLength, double[] dblArray)
        {
            var complexArray = new Complex[dataLength];
            for (var i = 0; i < dataLength; i++)
                complexArray[i] = new Complex(dblArray[i], 0);
            return complexArray;
        }

        private ScanGate scanGate1 = new ScanGate();
        private ScanGate scanGate2 = new ScanGate();
        private void checkBoxGate2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGate2.Checked)
            {
                scanGate2 = new ScanGate(70, 20, 0.2);
                updateGate2(scanGate2);
            }
        }

        private void updateGate2(ScanGate sg, int peakIndex = 0)
        {
            var gateListX = new List<double>
                                {
                                    sg.Offset + peakIndex,
                                    sg.Offset + peakIndex + sg.RecordLength,
                                    sg.Offset + peakIndex + sg.RecordLength,
                                    sg.Offset + peakIndex,
                                    sg.Offset + peakIndex
                                };
            var gateListY = new List<double> {sg.MaxAmp, sg.MaxAmp, -sg.MaxAmp, -sg.MaxAmp, sg.MaxAmp};

            gate2 = new PointPairList(gateListX.ToArray(), gateListY.ToArray());
        }

        private void checkBoxGate1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGate1.Checked)
            {
                scanGate1 = new ScanGate(20, 20, 0.3);
                updateGate1(scanGate1);
            }
        }

        private void updateGate1(ScanGate sg, int peakIndex = 0)
        {
            var gateListX = new List<double>
                                {
                                    sg.Offset + peakIndex,
                                    sg.Offset + peakIndex + sg.RecordLength,
                                    sg.Offset + peakIndex + sg.RecordLength,
                                    sg.Offset + peakIndex,
                                    sg.Offset + peakIndex
                                };
            var gateListY = new List<double> {sg.MaxAmp, sg.MaxAmp, -sg.MaxAmp, -sg.MaxAmp, sg.MaxAmp};

            gate1 = new PointPairList(gateListX.ToArray(), gateListY.ToArray());
        }
    }
}
