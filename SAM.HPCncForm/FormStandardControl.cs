using System;
using System.Globalization;
using System.Windows.Forms;
using SAM.Core.HPCNC;
using SAM.HPCncForm.Classes;

namespace SAM.HPCncForm
{
    public partial class FormStandardControl : Form
    {
        private readonly WaitTimer _timer = new WaitTimer();
        
        private bool infoReceived;
        private bool cncConnected;
        private bool newCommand;

        private CncCom _cncCom;

        private CMDTYPE _currentCommand = CMDTYPE.STATUS;

        public FormStandardControl()
        {
            InitializeComponent();
        }

        private void FormStandardControl_Load(object sender, EventArgs e)
        {
            populateComPorts();
        }

        private void connectButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                tryClosePreviousConnection();

                cncConnected = !cncConnected;
                if (!cncConnected)
                {
                    updateStatus("DISCONNECT");
                    return;
                }

                var port = comboBoxCOM.Text;
                createNewConnection(port);
            }
            catch (Exception ex)
            {
                cncConnected = false;
                error("Cannot connect CNC machine", ex.Message);
            }
            finally
            {
                updateConnectButtonText();
                if(cncConnected)
                    enableReceiving();
                else
                    disableUpdateTimer();
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if(!cncConnected)
            {
                disableUpdateTimer();
                return;
            }

            if(!infoReceived)
            {
                if(_timer.Overflow())
                {
                    _timer.ResetTimer();
                    updateStatus("NO RESPONSE");
                }
                else
                {
                    return;
                }
            }
            else if (_currentCommand == CMDTYPE.STATUS)
            {
                extractReceivedInfo();
            }

            if (!newCommand)
            {
                resetCurrentCommand();
                enableReceiving();
            }
            else
            {
                newCommand = false;
            }
        }

        private void extractReceivedInfo()
        {
            updateStatus(receivedInfo.Status);
            textBoxXA.Text = receivedInfo.Xa;
            textBoxYA.Text = receivedInfo.Ya;
            textBoxZA.Text = receivedInfo.Za;

            textBoxXm.Text = receivedInfo.Xm;
            textBoxYm.Text = receivedInfo.Ym;
            textBoxZm.Text = receivedInfo.Zm;

            textBoxCurrentFeedRate.Text = receivedInfo.Fp;
        }

        private void FormStandardControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            tryClosePreviousConnection();
        }

        private void buttonXplus_Click(object sender, EventArgs e)
        {
            _cncCom.Jog(JogDirection.XPLUS, (byte) trackBarManualFeedrate.Value);
            notifyWaitNewCommandSend();
        }

        private void notifyWaitNewCommandSend()
        {
            newCommand = true;
            _timer.StartWaiting(1000);
            enableReceiving();
        }

        private void buttonXminus_Click(object sender, EventArgs e)
        {
            _cncCom.Jog(JogDirection.YPLUS, (byte)trackBarManualFeedrate.Value);
            notifyWaitNewCommandSend();
        }

        private void trackBarAutoFeedRate_Scroll(object sender, EventArgs e)
        {
            textBoxAutoFeedrate.Text = trackBarAutoFeedRate.Value.ToString(CultureInfo.InvariantCulture);
        }

        private void trackBarManualFeedrate_Scroll(object sender, EventArgs e)
        {
            textBoxManualFeedrate.Text = trackBarManualFeedrate.Value.ToString(CultureInfo.InvariantCulture);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _cncCom.Reset();
            notifyWaitNewCommandSend();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            _cncCom.Home();
            notifyWaitNewCommandSend();
        }
    }
}
