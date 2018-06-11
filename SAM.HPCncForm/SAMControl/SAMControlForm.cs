using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SAM.Core;
using SAM.Core.DataProcessing;
using SAM.Core.HPCNC;
using SAM.Core.NIScope;
using ZedGraph;

namespace SAM.HPCncForm.SAMControl
{
    public partial class SAMControlForm : Form
    {
        public SAMControlForm()
        {
            InitializeComponent();
            getAvailableComPorts();
            initializeSystemParameters();
            initializeRecordSettings();
        }
        
        private JogDirection jogDirection = JogDirection.NONE;
        private void timerCncUpdate_Tick(object sender, EventArgs e)
        {
            if (cncDisconnected())
            {
                disableCncUpdateTimer();
                return;
            }

            switch (_cncCommand)
            {
                case CMDTYPE.STATUS:
                    getCncInfo();
                    break;
                case CMDTYPE.JOG:
                    cncJog(jogDirection);
                    break;
            }

            switch (triggerSource)
            {
                case TriggerSource.INTERNAL:
                    #region A Scan with Internal Trigger
                    try
                    {
                        numberOfRecords = 1;
                        configureDigitizerGeneralParameters();
                        var ascan = fetchData();
                        var samples = createSamplesArray(recordLength);
                        int peakIndex;
                        double peak;
                        var envelop = calculateHilbert(recordLength, ascan, out peak, out peakIndex);

                        configureAScanGraph();
                        var aScanSignal = new PointPairList(samples, ascan);
                        var upperBound = new PointPairList(samples, envelop);
                        var peakPoint = new PointPairList(new double[] { peakIndex }, new[] { peak });

                        var myPane = graphAScan.GraphPane;
                        myPane.CurveList.Clear();
                        myPane.AddCurve("A Scan", aScanSignal, Color.Blue, SymbolType.None);
                        myPane.AddCurve("Envelop", upperBound, Color.Green, SymbolType.None);
                        myPane.AddCurve(string.Format("Peak({0})", formatDouble(peak)), peakPoint, Color.Red, SymbolType.Circle);
                        graphAScan.AxisChange();

                        Refresh();

                        if(checkBoxVerify.Checked)
                        {
                            var ascanComplex = createComplexArray(recordLength, ascan);
                            DIP.FFT(ascanComplex, FourierTransform.Direction.Forward);

                            var FS = getSampleRate() / 1000000; // in MHz
                            var dF = FS / recordLength;
                            var f = new double[recordLength / 2];
                            for (int i = 0; i < recordLength / 2; i++)
                                f[i] = i * dF;

                            configureFrequencySpectrumGraph();
                            var freList = new List<double>();
                            for (int i = recordLength / 2 + 1; i < recordLength; i++)
                                freList.Add(ascanComplex[i].Magnitude);

                            freList.Reverse();
                            var fs = new PointPairList(f, freList.ToArray());
                            var myPaneB = graphBScan.GraphPane;
                            myPaneB.CurveList.Clear();
                            myPaneB.AddCurve("Magnitude Reponse", fs, Color.Blue, SymbolType.None);
                            graphBScan.AxisChange();
                        }
                    }
                    catch (Exception ex)
                    {
                        updateStatus(ex.Message);
                    }
                    finally
                    {
                        if (myScope != null)
                            myScope.Dispose();
                    }
                    break;
                    #endregion

                case TriggerSource.EXTERNAL:
                    #region A, B, C Scans with External Trigger
                    try
                    {
                        if (!CScanning())
                            return;

                        if (scanIndex >= bScanNumber)
                            stopScanning();
                        else
                            continueScanning();
                    }
                    catch (Exception ex)
                    {
                        error("Scanning Error", ex.Message);
                    }
                    break;
                    #endregion
            }
        }

        #region SCAN CONTROL
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                cScanFrm.Show();
                startScanning();
            }
            catch (Exception ex)
            {
                error("Start/Stop Scanning Error", ex.Message);
            }
        }

        private void buttonScanStop_Click(object sender, EventArgs e)
        {
            stopScanning();
        }

        private void buttonScanAbort_Click(object sender, EventArgs e)
        {
            stopScanning();
        }
        #endregion

        #region CNC CONTROL

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                tryClosePreviousConnection();
                toggleCncConnectStatus();

                if (cncDisconnected())
                    updateStatus("DISCONNECT");
                else
                    createNewConnection(getSelectComPort());
            }
            catch (Exception ex)
            {
                resetCncConnect();
                error("CNC Connection Error", ex.Message);
            }
            finally
            {
                updateConnectButtonText();
                if (cncConnected())
                {
                    setCncCommand(CMDTYPE.STATUS);
                    enableCncUpdateTimer();
                }
                else
                {
                    setCncCommand(CMDTYPE.NONE);
                    disableCncUpdateTimer();
                }
            }
        }

        private void buttonXminus_Click(object sender, MouseEventArgs e)
        {
            cncJog(JogDirection.XMINUS);
        }

        private void buttonXplus_Click(object sender, MouseEventArgs e)
        {
            cncJog(JogDirection.XPLUS);
        }

        private void buttonYplus_Click(object sender, MouseEventArgs e)
        {
            cncJog(JogDirection.YPLUS);
        }

        private void buttonYminus_Click(object sender, MouseEventArgs e)
        {
            cncJog(JogDirection.YMINUS);
        }

        private void buttonZplus_Click(object sender, MouseEventArgs e)
        {
            cncJog(JogDirection.ZPLUS);
        }

        private void buttonZminus_Click(object sender, MouseEventArgs e)
        {
            cncJog(JogDirection.ZMINUS);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
                updateStatus("Reset CNC");
                _cncCom.Reset();
            }
            catch (Exception ex)
            {
                error("CNC Reset Error", ex.Message);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            try
            {
                var ans = MessageBox.Show("CNC HOME?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (ans == DialogResult.OK )
                    _cncCom.Home();   
            }
            catch (Exception ex)
            {
                error("CNC Home Error", ex.Message);
            }
        }

        private void buttonAutoStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentCncStatus() == CncInfo.STATUS_FEEDHOLD)
                    _cncCom.Start();
                else
                {
                    var ans = MessageBox.Show("AUTO RUN?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (ans == DialogResult.OK)
                        _cncCom.GCode(createGcode(xr, yr, zr, autoSpeed), GCODE_FEEDRATE);
                }
  
            }
            catch (Exception ex)
            {
                error("CNC Auto Run Error", ex.Message);
            }
        }

        private void buttonAutoPause_Click(object sender, EventArgs e)
        {
            try
            {
                _cncCom.Pause();
            }
            catch (Exception ex)
            {
                error("CNC Pause Auto Error", ex.Message);
            }
        }

        private void buttonSetZeroX_Click(object sender, EventArgs e)
        {
            try
            {
                _cncCom.XabsSetZero();
            }
            catch (Exception ex)
            {
                error("CNC Set X Zero Error", ex.Message);
            }
        }

        private void buttonSetZeroY_Click(object sender, EventArgs e)
        {
            try
            {
                _cncCom.YabsSetZero();
            }
            catch (Exception ex)
            {
                error("CNC Set Y Zero Error", ex.Message);
            }
        }

        private void buttonSetZeroZ_Click(object sender, EventArgs e)
        {
            try
            {
                _cncCom.ZabsSetZero();
            }
            catch (Exception ex)
            {
                error("CNC Set Z Zero Error", ex.Message);
            }
        }

        private void releaseJoggingButton(object sender, MouseEventArgs e)
        {
            setCncCommand(CMDTYPE.STATUS);
        }
        #endregion

        #region SYSTEM PARAMETERS UPDATE
        private const string DOUBLE_FORMAT = "0.###";
        private void textBoxResolution_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref resolution, textBoxResolution.Text, MIN_RESOLUTION);
            textBoxResolution.Text = formatDouble(resolution);
        }

        private void textBoxDistance_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref distance, textBoxDistance.Text, 0);
            textBoxDistance.Text = formatDouble(distance);
        }

        private void textBoxBScanNumber_Leave(object sender, EventArgs e)
        {
            updateIntParameters(ref bScanNumber, textBoxBScanNumber.Text, 0);
            textBoxBScanNumber.Text = bScanNumber.ToString(CultureInfo.InvariantCulture);
        }

        private void textBoxScanSpeed_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref scanSpeed, textBoxScanSpeed.Text, 0);
            textBoxScanSpeed.Text = formatDouble(scanSpeed);
        }

        private void comboBoxTriggerSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTriggerSource.SelectedIndex)
            {
                case 1:
                    triggerSource = TriggerSource.INTERNAL;
                    break;
                case 2:
                    triggerSource = TriggerSource.EXTERNAL;
                    break;
                default:
                    triggerSource = TriggerSource.NONE;
                    break;
            }
        }

        private void textBoxTriggerLevel_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref triggerLevel, textBoxTriggerLevel.Text, 0);
            textBoxTriggerLevel.Text = formatDouble(triggerLevel);
        }

        private void textBoxVerticalRange_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref verticalRange, textBoxVerticalRange.Text, 0);
            textBoxVerticalRange.Text = formatDouble(verticalRange);
        }

        private void textBoxTimeOut_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref fetchTimeout, textBoxTimeOut.Text, 0);
            textBoxTimeOut.Text = formatDouble(fetchTimeout);
        }

        private void textBoxTriggerDelay_Leave(object sender, EventArgs e)
        {
            calculateTriggerDelayus();
        }

        private void textBoxRecordLength_Leave(object sender, EventArgs e)
        {
            updateIntParameters(ref recordLength, textBoxRecordLength.Text, 0);
            textBoxRecordLength.Text = recordLength.ToString(CultureInfo.InvariantCulture);
        }

        private void comboBoxChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            channel = comboBoxChannel.Text;
        }

        private void comboBoxSampleRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            sampleRate = getSampleRate();
        }

        private void comboBoxResourceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            resourceName = comboBoxResourceName.Text;
        }

        private void leaveTextBox_whenPressEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
                SendKeys.Send("{TAB}");
        }

        private void textBoxMax_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref quantizationMax, textBoxMax.Text, 0);
            textBoxMax.Text = formatDouble(quantizationMax);
        }

        private void textBoxMin_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref quantizationMin, textBoxMin.Text, 0);
            textBoxMin.Text = formatDouble(quantizationMin);
        }

        private void textBoxXref_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref xr, textBoxXref.Text);
            textBoxXref.Text = formatDouble(xr);
        }

        private void textBoxYref_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref yr, textBoxYref.Text);
            textBoxYref.Text = formatDouble(yr);
            
        }

        private void textBoxZref_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref zr, textBoxZref.Text);
            textBoxZref.Text = formatDouble(zr);
        }

        private void textBoxAutoSpeed_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref autoSpeed, textBoxAutoSpeed.Text);
            textBoxAutoSpeed.Text = formatDouble(autoSpeed);
        }

        private void textBoxPlotAMax_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref plotAScanMax, textBoxPlotAMax.Text);
            textBoxPlotAMax.Text = formatDouble(plotAScanMax);
        }

        private void textBoxPlotAMin_Leave(object sender, EventArgs e)
        {
            updateDoubleParameters(ref plotAScanMin, textBoxPlotAMin.Text);
            textBoxPlotAMin.Text = formatDouble(plotAScanMin);
        }
        #endregion

        private void buttonSaveFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if(string.IsNullOrWhiteSpace(dialog.SelectedPath))
                return;

            _saveFolder = dialog.SelectedPath;
            updateSaveFilePath();
        }

        private void textBoxSaveFileName_Leave(object sender, EventArgs e)
        {
            var newFileName = textBoxSaveFileName.Text;

            if (validateFileName(newFileName))
            {
                _saveFileName = newFileName;
                updateSaveFilePath();
            }
            else
            {
                textBoxSaveFileName.Text = _saveFileName;
            }
        }
    }
}
