using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Numerics;
using System.Text;
using System.Threading;
using SAM.Core.DataProcessing;
using SAM.Core.HPCNC;
using SAM.Core.NIScope;
using SAM.Core;
using ZedGraph;

namespace SAM.HPCncForm.SAMControl
{
    public partial class SAMControlForm
    {
        private double distance;
        private double resolution;
        private const double MIN_RESOLUTION = 0.02;
        private const int GCODE_FEEDRATE = 100;

        private int numberOfRecords;
        private int maxRecords;
        private int resolutionRecords;
        private int scanIndex;
        private int bScanNumber;
        private double scanSpeed;

        private string resourceName;
        private string channel;
        private double triggerLevel;
        private double triggerDelay;
        private double fetchTimeout;
        private double verticalRange;
        private double sampleRate;
        private int recordLength;

        private double quantizationMax;
        private double quantizationMin;

        private double plotAScanMax;
        private double plotAScanMin;

        private TriggerSource triggerSource;
        private const string TRIGGER_SOURCE = "VAL_EXTERNAL";

        private double xr;
        private double yr;
        private double zr;
        private double autoSpeed;

        private double xa;
        private double ya;

        private bool _cncConnected;
        private bool _isScanning;
        private CncCom _cncCom;
        private CncInfo _receivedInfo;
        private CMDTYPE _cncCommand = CMDTYPE.NONE;

        private niScope myScope;

        private readonly CScanForm cScanFrm = new CScanForm();

        private MoveDirection _moveDir = MoveDirection.NONE;

        private Thread processDataThread;

        private enum MoveDirection
        {
            NONE,
            Y,
            X
        }

        #region SCAN OPERATIONS
        private void startScanning()
        {
            calculateScanParameters();
            cScanFrm.pictureBoxCScan.Height = bScanNumber;
            cScanFrm.pictureBoxCScan.Width = numberOfRecords;
            cScanFrm.pictureBoxCScan.Image = new Bitmap(numberOfRecords, bScanNumber);
            configureDigitizerGeneralParameters();
            scanIndex = 0;
            _isScanning = true;
            _moveDir = MoveDirection.X;
            cncMoveX(distance + MIN_RESOLUTION, scanSpeed);
        }

        private void stopScanning()
        {
            _isScanning = false;
            var savePath = createSaveFilePath();
            cScanFrm.pictureBoxCScan.Image.Save(savePath, ImageFormat.Jpeg);
        }

        private void continueScanning()
        {
            var yRef = calculateYref(scanIndex + 1, resolution);
            if (_moveDir == MoveDirection.X)
            {
                var xRef = selectXref(scanIndex, distance);
                var xArrived = doubleEqual(xa, xRef);
                if (!xArrived)
                    return;

                if (currentCncStatus() != "Idle")
                    _cncCom.Reset();

                plotPreviousScanData();
                getCurrentScanData();

                _moveDir = MoveDirection.Y;
                cncMoveY(yRef, scanSpeed);

                startThreadConvertDataToRowImage();
            }

            if (_moveDir == MoveDirection.Y)
            {
                var yArrived = doubleEqual(ya, yRef);
                if (!yArrived)
                    return;

                if (!cncIdle())
                    _cncCom.Reset();

                scanIndex++;
                if (scanIndex >= bScanNumber)
                {
                    stopScanning();
                    return;
                }

                textBoxBScanCount.Text = scanIndex.ToString(CultureInfo.InvariantCulture);

                configureDigitizerGeneralParameters();
                _moveDir = MoveDirection.X;
                var xRef = selectXref(scanIndex, distance);
                cncMoveX(xRef, scanSpeed);
            }
        }

        private void startThreadConvertDataToRowImage()
        {
            waitProcessDataThread();
            processDataThread = new Thread(convertBScanDataToCScanImageRow);
            processDataThread.Start();
        }

        private void getCurrentScanData()
        {
            bScanData = fetchData();
        }

        private void plotPreviousScanData()
        {
            waitProcessDataThread();
            if (bScanPixels == null)
                return;

            for (int col = 0; col < numberOfRecords; col++)
            {
                var pixelVal = bScanPixels[col];
                ((Bitmap)cScanFrm.pictureBoxCScan.Image).SetPixel(col, scanIndex, Color.FromArgb(pixelVal, pixelVal, pixelVal));
            }

            configureAScanGraph();
            configureBScanGraph();

            var paneB = graphBScan.GraphPane;
            paneB.CurveList.Clear();
            var peakPoints = new PointPairList(bSamples.ToArray(), bPeaks.ToArray());
            paneB.AddCurve("B Scan", peakPoints, Color.Red, SymbolType.Circle);
            graphBScan.AxisChange();

            cScanFrm.pictureBoxCScan.Refresh();
            cScanFrm.Refresh();
        }

        private void waitProcessDataThread()
        {
            if (processDataThread != null)
                processDataThread.Join();
        }

        private double[] bScanData;
        private List<double> bSamples;
        private List<double> bPeaks;
        private byte[] bScanPixels;

        private void convertBScanDataToCScanImageRow()
        {
            bScanData = fetchData();
            bSamples = new List<double>();
            bPeaks = new List<double>();
            bScanPixels = new byte[numberOfRecords];

            var savePath = createSaveDataPath();
            using (var writer = new BinaryWriter(File.Open(savePath, FileMode.Create)))
            {
                for (int col = 0; col < numberOfRecords; col++)
                {
                    var aScanData = new double[recordLength];
                    for (int i = 0; i < recordLength; i++)
                    {
                        aScanData[i] = bScanData[col*recordLength + i];
                        if(checkBoxSaveRawData.Checked)
                            writer.Write(aScanData[i]);
                    }

                    int peakIndex;
                    double peak;
                    calculateHilbert(recordLength, aScanData, out peak, out peakIndex);

                    if (peak > quantizationMin)
                    {
                        bSamples.Add(col);
                        bPeaks.Add(-peakIndex);
                    }

                    var x = !isEven(scanIndex) ? col : (numberOfRecords - col - 1);
                    var pixelVal = byteQuantize(peak, quantizationMin, quantizationMax);
                    bScanPixels[x] = pixelVal;
                }
            }
        }

        private string createSaveDataPath()
        {
            return string.Format("{0}{1}_{2}.bin", _saveFolder, _saveFileName, scanIndex);
        }

        private void calculateScanParameters()
        {
            if (!validatePositiveDouble(textBoxDistance.Text, out distance))
                throw new Exception("Invalid Distance");

            if (!validatePositiveDouble(textBoxResolution.Text, out resolution))
                throw new Exception("Invalid Resolution");

            if (!validateNonNegativeInteger(textBoxBScanNumber.Text, out bScanNumber))
                throw new Exception("Invalid B Scan Number");

            if (!validatePositiveDouble(textBoxScanSpeed.Text, out scanSpeed))
                throw new Exception("Invalid Scan Speed");

            maxRecords = (int)(distance / MIN_RESOLUTION);
            resolutionRecords = (int)(resolution / MIN_RESOLUTION);
            numberOfRecords = maxRecords / resolutionRecords;
        }

        private double[] fetchData()
        {
            var waveInfo = new niScopeWfmInfo[numberOfRecords];
            var waveform = new double[recordLength * numberOfRecords];
            try
            {
                myScope.Fetch(channel, fetchTimeout, recordLength, waveform, waveInfo);
                return waveform;
            }
            catch (Exception)
            {
                return bScanData;
            }
        }
        #endregion

        private bool cncIdle()
        {
            return currentCncStatus() == CncInfo.STATUS_IDLE;
        }

        private void cncMoveX(double xRef, double speed)
        {
            _cncCom.GCode(createGcodeMoveX(xRef, speed), GCODE_FEEDRATE);
        }

        private void cncMoveY(double yRef, double speed)
        {
            _cncCom.GCode(createGcodeMoveY(yRef, speed), GCODE_FEEDRATE);
        }

        private static bool doubleEqual(double d1 , double d2)
        {
            return Math.Abs(d1 - d2) < 0.000001;
        }

        private static double calculateYref(int scanIdx, double yStep)
        {
            return -scanIdx*yStep;
        }

        private static double selectXref(int scanIdx, double xDestination)
        {
            return !isEven(scanIdx) ? -MIN_RESOLUTION : (xDestination + MIN_RESOLUTION);
        }

        private static bool isEven(int scanIdx)
        {
            return scanIdx%2 == 0;
        }

        private static bool validatePositiveDouble(string str, out double val)
        {
            val = 0;
            try
            {
                var valid = double.TryParse(str, out val);
                return (valid || val > 0);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static bool validateNonNegativeInteger(string str, out int val)
        {
            val = 0;
            try
            {
                var valid = int.TryParse(str, out val);
                return (valid || val >= 0);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void getAvailableComPorts()
        {
            var ports = SerialPort.GetPortNames();
            foreach (var port in ports)
                comboBoxCncCom.Items.Add(port);
        }

        private void createNewConnection(string port)
        {
            _cncCom = new CncCom(port);
        }

        private string currentCncStatus()
        {
            return textBoxCncStatus.Text;
        }

        private void error(string errorMsg, string exceptionMsg)
        {
            updateStatus(string.Format("Error: {0}. {1}", errorMsg, exceptionMsg));
        }

        private void tryClosePreviousConnection()
        {
            try
            {
                if (_cncCom == null)
                    return;

                _cncCom.Dispose();
            }
            catch (Exception)
            {
            }
        }

        private void updateConnectButtonText()
        {
            buttonConnect.Text = _cncConnected ? "Disconnect" : "Connect";
        }

        private void updateStatus(string msg)
        {
            textBoxCncStatus.Text = msg;
        }

        private void enableCncUpdateTimer()
        {
            timerMainLoop.Enabled = true;
        }

        private void disableCncUpdateTimer()
        {
            timerMainLoop.Enabled = false;
        }

        private void extractReceivedInfo()
        {
            if(_receivedInfo == null)
                return;

            updateStatus(_receivedInfo.Status);
            xa = double.Parse(_receivedInfo.Xa);
            ya = double.Parse(_receivedInfo.Ya);
            textBoxXa.Text = _receivedInfo.Xa;
            textBoxYa.Text = _receivedInfo.Ya;
            textBoxZa.Text = _receivedInfo.Za;
        }

        private void getCncInfo()
        {
            var cncInfo = _cncCom.GetCncInfo();
            _receivedInfo = new CncInfo(Encoding.ASCII.GetString(cncInfo.ToArray()));
            extractReceivedInfo();
        }

        private static string createGcode(double xr, double yr, double zr, double speed)
        {
            return string.Format("G01X{0}Y{1}Z{2}F{3}", xr, yr, zr, speed);
        }

        private static string createGcodeMoveX(double xr, double speed)
        {
            return string.Format("G01X{0}F{1}", xr, speed);
        }

        private static string createGcodeMoveY(double yr, double speed)
        {
            return string.Format("G01Y{0}F{1}", yr,  speed);
        }

        private static double[] calculateHilbert(int dataLength, double[] dblAScan, out double peak, out int peakIndex)
        {
            var complexSignal = createComplexArray(dataLength, dblAScan);
            return DIP.FastHT(complexSignal, FourierTransform.Direction.Forward, out peak, out peakIndex);
        }

        private static Complex[] createComplexArray(int dataLength, double[] dblAScan)
        {
            var hilbertSignal = new Complex[dataLength];
            for (var i = 0; i < dataLength; i++)
                hilbertSignal[i] = new Complex(dblAScan[i], 0);
            return hilbertSignal;
        }

        private static double[] createSamplesArray(int dataLength)
        {
            var samples = new double[dataLength];
            for (var i = 0; i < dataLength; i++)
                samples[i] = i;
            return samples;
        }

        private void configureBScanGraph()
        {
            var myPane = graphBScan.GraphPane;
            myPane.Title.Text = "B SCAN";
            myPane.YAxis.Title.Text = "Sample";
            myPane.XAxis.Title.Text = "Record";
            myPane.XAxis.Scale.Max = numberOfRecords;
            myPane.CurveList.Clear();
        }

        private void configureAScanGraph()
        {
            var myPane = graphAScan.GraphPane;
            myPane.Title.Text = "A SCAN";
            myPane.YAxis.Title.Text = "Amplitude(V)";
            myPane.XAxis.Title.Text = "Sample";
            myPane.XAxis.Scale.Max = recordLength;
            myPane.YAxis.Scale.Max = plotAScanMax;
            myPane.YAxis.Scale.Min = plotAScanMin;
            myPane.CurveList.Clear();
        }

        private static byte byteQuantize(double input, double minimum, double maximum)
        {
            var unit = (maximum - minimum) / 256;
            var val = (input - minimum) / unit;
            val = Math.Max(byte.MinValue, val);
            val = Math.Min(val, byte.MaxValue);
            return (byte)val;
        }

        private double getSampleRate()
        {
            try
            {


                var rate = comboBoxSampleRate.Text;
                switch (rate)
                {
                    case "100M":
                    case "500M":
                    case "750M":
                    case "1000M":
                    case "1500M":
                    case "2000M":
                        var str = rate.Substring(0, rate.Length - 1);
                        var sRate = double.Parse(str)*1000000;
                        return sRate;

                    default:
                        return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private bool cncConnected()
        {
            return _cncConnected;
        }

        private void resetCncConnect()
        {
            _cncConnected = false;
        }

        private bool cncDisconnected()
        {
            return !_cncConnected;
        }

        private void toggleCncConnectStatus()
        {
            _cncConnected = !_cncConnected;
        }

        private void setCncCommand(CMDTYPE cmd)
        {
            _cncCommand = cmd;
        }

        private string getSelectComPort()
        {
            return comboBoxCncCom.Text;
        }

        private bool CScanning()
        {
            return _isScanning;
        }

        private static void updateDoubleParameters(ref double parameter, string text, double minimum = double.MinValue)
        {
            double d;
            if (!double.TryParse(text, out d)) return;

            if (d >= minimum)
                parameter = d;
        }

        private static void updateIntParameters(ref int parameter, string text, int minimum = int.MinValue)
        {
            int v;
            if(!int.TryParse(text, out v)) return;

            if(v >= minimum)
                parameter = v;
        }

        private static string formatDouble(double num)
        {
            return num.ToString(DOUBLE_FORMAT);
        }

        private void initializeSystemParameters()
        {
            comboBoxResourceName.SelectedIndex = 0;
            comboBoxTriggerSource.SelectedIndex = 0;
            comboBoxChannel.SelectedIndex = 0;
            comboBoxSampleRate.SelectedIndex = 0;
            comboBoxGrayLevel.SelectedIndex = 0;

            updateDoubleParameters(ref triggerLevel, textBoxTriggerLevel.Text, 0);
            updateDoubleParameters(ref verticalRange, textBoxVerticalRange.Text, 0);
            updateDoubleParameters(ref fetchTimeout, textBoxTimeOut.Text, 0);
            updateIntParameters(ref recordLength, textBoxRecordLength.Text, 0);
            updateDoubleParameters(ref xr, textBoxXref.Text);
            updateDoubleParameters(ref yr, textBoxYref.Text);
            updateDoubleParameters(ref zr, textBoxZref.Text);
            updateDoubleParameters(ref autoSpeed, textBoxAutoSpeed.Text);
            updateDoubleParameters(ref quantizationMax, textBoxMax.Text);
            updateDoubleParameters(ref quantizationMin, textBoxMin.Text);
            updateDoubleParameters(ref plotAScanMax, textBoxPlotAMax.Text);
            updateDoubleParameters(ref plotAScanMin, textBoxPlotAMin.Text);
            calculateTriggerDelayus();

            configureAScanGraph();
        }

        private void configureDigitizerGeneralParameters()
        {
            myScope = new niScope(resourceName, true, true);
            myScope.ConfigureVertical(channel, verticalRange, 0, 1, 1, true);
            myScope.ConfigureChanCharacteristics(channel, 50, -1);
            myScope.ConfigureHorizontalTiming(sampleRate, recordLength, 0, numberOfRecords, true);
            myScope.ConfigureTriggerEdge(TRIGGER_SOURCE, triggerLevel, 1, 1, 0, triggerDelay);
            myScope.InitiateAcquisition();
        }

        private void calculateTriggerDelayus()
        {
            double triggerDelayUs = 0;
            updateDoubleParameters(ref triggerDelayUs, textBoxTriggerDelay.Text, 0);
            textBoxTriggerDelay.Text = formatDouble(triggerDelayUs);
            triggerDelay = triggerDelayUs/1000000;
        }

        private void cncJog(JogDirection direction)
        {
            try
            {
                setCncCommand(CMDTYPE.JOG);
                jogDirection = direction;
                var cncInfo = _cncCom.Jog(direction, (byte)numericUpDownFeedRate.Value);
                _receivedInfo = new CncInfo(Encoding.ASCII.GetString(cncInfo.ToArray()));
                extractReceivedInfo();
            }
            catch (Exception ex)
            {
                error("CNC Jog Error", ex.Message);
            }
        }

        private const string SAVE_FILE_EXT = ".JPEG";
        private string _saveFolder;
        private string _saveFileName;
        private void initializeRecordSettings()
        {
            _saveFolder = AppDomain.CurrentDomain.BaseDirectory;
            _saveFileName = "Untitiled";
            updateSaveFilePath();
        }

        private string createSaveFilePath()
        {
            if (_saveFolder[_saveFolder.Length - 1] == '\\')
                return _saveFolder + _saveFileName + SAVE_FILE_EXT;
         
            return _saveFolder + @"\" + _saveFileName + SAVE_FILE_EXT;
        }

        private void updateSaveFilePath()
        {
            textBoxSaveFolder.Text = _saveFolder;
            textBoxSaveFileName.Text = _saveFileName;
            textBoxSaveFilePath.Text = createSaveFilePath();
        }

        private void configureFrequencySpectrumGraph()
        {
            var myPane = graphBScan.GraphPane;
            myPane.Title.Text = "Freqency Spectrum";
            myPane.YAxis.Title.Text = "Amplitude";
            myPane.XAxis.Title.Text = "Frequency (MHz)";
            myPane.XAxis.Scale.Max = getSampleRate()/(2*1000000);
            myPane.CurveList.Clear();
        }

        private static bool validateFileName(string newFileName)
        {
            return !string.IsNullOrWhiteSpace(newFileName) &&
                   newFileName.IndexOfAny(Path.GetInvalidFileNameChars()) < 0;
        }
    }
}
