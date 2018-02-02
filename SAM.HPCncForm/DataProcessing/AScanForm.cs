using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAM.Core.DataProcessing;
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
        private void checkBoxGate1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGate1.Checked)
                showGate1SettingForm();
            else
                hideGate1SettingForm();
        }

        private void hideGate1SettingForm()
        {

        }



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
            pictureBox.Width = numberOfRecords / shrinkFactor;
            pictureBox.Height = numberOfBscan / shrinkFactor;
            pictureBox.Image = new Bitmap(numberOfRecords / shrinkFactor, numberOfBscan / shrinkFactor);
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
            currentBScan = SamBScanLoader.LoadFloat(path, numberOfRecords, recordLength);
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
        private int offset2;
        private int recordLength2;
        private double gateMax2;
        private const int recordLength = 150;
        private const int numberOfRecords = 1400;
        private const int numberOfBscan = 550;
        private PointPairList gate1;
        private PointPairList gate2;

        private void timerMainLoop_Tick(object sender, EventArgs e)
        {
            if (count >= numberOfBscan) 
            {
                mainsw.Stop();
                new Thread(()=>MessageBox.Show("Total time: " + mainsw.Elapsed.TotalSeconds)).Start();
                timerMainLoop.Enabled = false;
                return;
            }

            waitLoadingData();
            var floatBscan = new float[numberOfRecords,recordLength];
            for (int i = 0; i < numberOfRecords; i++)
            {
                for (int j = 0; j < recordLength; j++)
                {
                    floatBscan[i, j] = currentBScan[i, j];
                }
            }

            loadNewBscan();

            var samples = createSamplesArray(150);
            var myPane = graphAScan.GraphPane;
            myPane.CurveList.Clear();
            var ascanForDisplay = new double[150];
            for (int i = 0; i < 150; i++)
                ascanForDisplay[i] = floatBscan[10, i];

            var aScanSignal = new PointPairList(samples, ascanForDisplay);
            myPane.AddCurve("A Scan", aScanSignal, Color.Blue,SymbolType.None);
            myPane.AddCurve("Gate 1", gate1, Color.Green, SymbolType.None);
            myPane.AddCurve("Gate 2", gate2, Color.Maroon, SymbolType.None);
            graphAScan.AxisChange();

            var pixels = new byte[numberOfRecords/shrinkFactor];
            var pixels1 = new byte[numberOfRecords/shrinkFactor];
            var pixels2 = new byte[numberOfRecords/shrinkFactor];
            Parallel.For(0, numberOfRecords / shrinkFactor, col =>
            {
                {
                    var ascan = new double[150];
                    for (int i = 0; i < 150; i++)
                        ascan[i] = floatBscan[col * shrinkFactor, i];

                    var ascan1 = new double[recordLength1];
                    for (int i = 0; i < recordLength1; i++)
                    {
                        var idx = i + offset1;
                        ascan1[i] = floatBscan[col*shrinkFactor, idx];
                    }

                    var ascan2 = new double[recordLength2];
                    for (int i = 0; i < recordLength2; i++)
                    {
                        var idx = i + offset2;
                        ascan2[i] = floatBscan[col * shrinkFactor, idx];
                    }

                    double peak;
                    int peakIndex;
                    calculateHilbert(recordLength, ascan, out peak, out peakIndex);

                    var pixelVal = convertToByteWithRange(peak, 0, 0.8);
                    pixels[col] = pixelVal;

                    calculateHilbert(recordLength1, ascan1, out peak, out peakIndex);
                    pixelVal = convertToByteWithRange(peak, 0, gateMax1);
                    pixels1[col] = pixelVal;

                    calculateHilbert(recordLength2, ascan2, out peak, out peakIndex);
                    pixelVal = convertToByteWithRange(peak, 0, gateMax2);
                    pixels2[col] = pixelVal;
                }
            });

            for (int i = 0; i < numberOfRecords / shrinkFactor; i++)
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

        private const string DOUBLE_FORMAT = "0.###";
        private static string formatDouble(double num)
        {
            return num.ToString(DOUBLE_FORMAT);
        }


        private void checkBoxGate2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGate2.Checked)
            {
                offset2 = 85;
                recordLength2 = 20;
                gateMax2 = 0.25;
                var gateListX = new List<double>() { offset2, offset2 + recordLength2, offset2 + recordLength2, offset2, offset2 };
                var gateListY = new List<double>() { gateMax2, gateMax2, -gateMax2, -gateMax2, gateMax2 };

                gate2 = new PointPairList(gateListX.ToArray(), gateListY.ToArray());
            }
        }

        private int offset1;
        private int recordLength1;
        private double gateMax1;
        private void showGate1SettingForm()
        {
            offset1 = 60;
            recordLength1 = 20;
            gateMax1 = 0.7;
            var gateListX = new List<double>()
                               {offset1, offset1 + recordLength1, offset1 + recordLength1, offset1, offset1};
            var gateListY = new List<double>() {gateMax1, gateMax1, -gateMax1, -gateMax1, gateMax1};

            gate1 = new PointPairList(gateListX.ToArray(), gateListY.ToArray());
        }
    }
}
