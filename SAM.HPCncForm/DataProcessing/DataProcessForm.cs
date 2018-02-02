using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using SAM.Core.DataProcessing;
using SAM.Core.HPCNC;
using ZedGraph;

namespace SAM.HPCncForm.DataProcessing
{
    public partial class DataProcessForm : Form
    {
        public DataProcessForm()
        {
            InitializeComponent();
        }

        private bool processing;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            processing = !processing;
            if(processing)
                startProcessingData();
            else
                stopProcessingData();
        }

        private void startProcessingData()
        {
            pictureBoxCSCAN.Image = new Bitmap(pictureBoxCSCAN.Width, pictureBoxCSCAN.Height);
            zedGraphControlBSCAN.GraphPane.CurveList.Clear();
            zedGraphControlASCAN.GraphPane.CurveList.Clear();
            indexAScan = 500;
            indexBScan = 0;
            timerScan.Enabled = true;
            buttonStart.Text = "Stop";
            bSamples.Clear();
        }

        private void plotAScan(int index, out int imax, out double peak)
        {
            var dblAScan = extractAscan(index);
            var dataLength = dblAScan.Length;
            var myPane = zedGraphControlASCAN.GraphPane;
            myPane.CurveList.Clear();

            var samples = createSamplesArray(dataLength);
            var aScanSignal = new PointPairList(samples, dblAScan);
            myPane.AddCurve("A Scan", aScanSignal, Color.Blue, SymbolType.None);

            var envelop = detectEnvelop(dataLength, dblAScan);
            var upperBound = new PointPairList(samples, envelop);
            myPane.AddCurve("Envelop", upperBound, Color.Green, SymbolType.None);

            peak = envelop.Max(out imax);
            var peakPoint = new PointPairList(new double[] {imax}, new double[] {peak});
            myPane.AddCurve(string.Format("Peak({0})",peak.ToString("0.####")), peakPoint, Color.Red, SymbolType.Circle);
            zedGraphControlASCAN.AxisChange();
            Refresh();
        }

        private static double[] detectEnvelop(int dataLength, double[] dblAScan)
        {
            var hilbertSignal = new Complex[dataLength];
            for (var i = 0; i < dataLength; i++)
                hilbertSignal[i] = new Complex(dblAScan[i], 0);

            DIP.FHT(hilbertSignal, FourierTransform.Direction.Forward);

            var envelop = new double[dataLength];
            for (var i = 0; i < dataLength; i++)
                envelop[i] = Math.Sqrt(Math.Pow(dblAScan[i], 2) + Math.Pow(hilbertSignal[i].Magnitude, 2));

            return envelop;
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

        private double[] extractAscan(int index)
        {
            var dblAscan = new double[recordLength];
            for (var i = 0; i < recordLength; i++)
            {
                dblAscan[i] = dblBScan[index, i];
            }
            return dblAscan;
        }

        private double[,] dblBScan;
        private void DataProcessForm_Load(object sender, EventArgs e)
        {
            loadBScanSample(400);
            configureAScanGraph();
            configureBScanGraph();
        }

        private const int numberOfRecords = 2500;
        private const int recordLength = 500;
        private void loadBScanSample(int index)
        {
            var iPath = string.Format(@"D:\CurrentWork\Matlab\SamData\CoinNov16\coinNov16_{0}.dat",index);
            dblBScan = SamBScanLoader.LoadDouble(iPath, numberOfRecords, recordLength);
        }

        private AScanTrack aScanTrack = new AScanTrack();
        private int indexAScan = 0;
        private int indexBScan = 0;
        private List<double> bSamples = new List<double>();
        private List<double> bPeaks = new List<double>();
        private void timerScan_Tick(object sender, EventArgs e)
        {
            //indexAScan++;
            indexAScan = aScanTrack.Next();

            if(indexAScan == -1)
            {
                indexBScan++;
                if(indexBScan >= 400)
                    stopProcessingData();
                else
                {
                    bSamples.Clear();
                    zedGraphControlBSCAN.GraphPane.CurveList.Clear();
                    loadBScanSample(400 + indexBScan);
                }
                //indexAScan = 500;
                return;
            }

            int imax;
            double peak;
            plotAScan(indexAScan, out imax, out peak);

            if(peak > 0.02)
            {
                bSamples.Add(indexAScan);
                bPeaks.Add(-imax);
                zedGraphControlBSCAN.GraphPane.CurveList.Clear();
                var bPane = zedGraphControlBSCAN.GraphPane;
                var peakPoints = new PointPairList(bSamples.ToArray(), bPeaks.ToArray());
                bPane.AddCurve("B Scan", peakPoints, Color.Red, SymbolType.Circle);
                zedGraphControlBSCAN.AxisChange();
            }

            var y = indexBScan;
            var x = indexAScan - 500;
            if (aScanTrack.Direction == AScanDirection.RightToLeft)
            {
                x = 2000 - indexAScan;
            }

            var pixelVal = convertToByteWithRange(peak, 0.02, 0.35);
            ((Bitmap)pictureBoxCSCAN.Image).SetPixel(x, y, Color.FromArgb(pixelVal,pixelVal,pixelVal));
            pictureBoxCSCAN.Refresh();
        }

        private byte convertToByteWithRange(double input, double minimum, double maximum)
        {
            var unit = (maximum - minimum)/256;
            var val = (input - minimum)/unit;
            val = Math.Max(byte.MinValue, val);
            val = Math.Min(val, byte.MaxValue);
            return (byte) val;
        }
    }
}
