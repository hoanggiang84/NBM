using System;
using System.Globalization;
using System.Windows.Forms;
using SAM.Core.HPCNC;

namespace SAM.HPCncForm
{
    public partial class FormStandardControl : Form
    {
        private bool cncConnected;

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

            if (_currentCommand == CMDTYPE.STATUS)
            {
                getCncInfo();
            }
        }

        private void FormStandardControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            tryClosePreviousConnection();
        }

        private void buttonXplus_Click(object sender, MouseEventArgs e)
        {
            _cncCom.Jog(JogDirection.XPLUS, (byte) trackBarManualFeedrate.Value);
            _currentCommand = CMDTYPE.JOG;
        }

        private void buttonXminus_Click(object sender, MouseEventArgs e)
        {
            _cncCom.Jog(JogDirection.XMINUS, (byte)trackBarManualFeedrate.Value);
            _currentCommand = CMDTYPE.JOG;
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
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            _cncCom.Home();
        }

        private void buttonYminus_Click(object sender, MouseEventArgs e)
        {
            _cncCom.Jog(JogDirection.YMINUS, (byte)trackBarManualFeedrate.Value);
            _currentCommand = CMDTYPE.JOG;
        }

        private void buttonYplus_Click(object sender, MouseEventArgs e)
        {
            _cncCom.Jog(JogDirection.YPLUS, (byte)trackBarManualFeedrate.Value);
            _currentCommand = CMDTYPE.JOG;
        }

        private void buttonZplus_Click(object sender, MouseEventArgs e)
        {
            _cncCom.Jog(JogDirection.ZPLUS, (byte)trackBarManualFeedrate.Value);
            _currentCommand = CMDTYPE.JOG;
        }

        private void buttonZminus_Click(object sender, MouseEventArgs e)
        {
            _cncCom.Jog(JogDirection.ZMINUS, (byte)trackBarManualFeedrate.Value);
            _currentCommand = CMDTYPE.JOG;
        }

        private void buttonSetXabsZero_Click(object sender, EventArgs e)
        {
            _cncCom.XabsSetZero();
        }

        private void buttonSetYabsZero_Click(object sender, EventArgs e)
        {
            _cncCom.YabsSetZero();
        }

        private void buttonSetZabsZero_Click(object sender, EventArgs e)
        {
            _cncCom.ZabsSetZero();
        }

        private void buttonSendGcode_Click(object sender, EventArgs e)
        {
            var gcode = textBoxGcode.Text.ToUpper();
            _cncCom.GCode(gcode, (byte) trackBarAutoFeedRate.Value);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            _cncCom.Start();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _cncCom.Pause();
        }

        private void releaseJoggingButton(object sender, MouseEventArgs e)
        {
            _currentCommand = CMDTYPE.STATUS;
        }
    }
}
