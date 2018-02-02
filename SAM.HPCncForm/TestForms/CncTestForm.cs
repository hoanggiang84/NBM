using System;
using System.Globalization;
using System.IO.Ports;
using System.Windows.Forms;
using SAM.Core.HPCNC;

namespace SAM.HPCncForm
{
    public partial class FormTestCnc : Form
    {
        private delegate void SetTextCallback(TextBox textBox, string text);

        public FormTestCnc()
        {
            InitializeComponent();
        }

        private void FormHPCnc_Load(object sender, EventArgs e)
        {
            try
            {
                var ports = SerialPort.GetPortNames();
                foreach (var port in ports)
                    comboBoxSerial.Items.Add(port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Cannot get COM ports: {0}", ex));
            }
        }

        private CncCom _gantry = new CncCom("COM1");

        private void buttonGetInfo_Click(object sender, EventArgs e)
        {
            if(!cnc_connecting())
                return;

            _gantry.GetCncInfo();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            resetUpdateTimer();
        }

        private void resetUpdateTimer()
        {
            timerUpdate.Enabled = false;
        }

        private void FormHPCnc_FormClosed(object sender, FormClosedEventArgs e)
        {
            _gantry.Dispose();
        }

        private void checkBoxConnect_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                try_close_last_connection();

                var portName = comboBoxSerial.Text;
                if (string.IsNullOrWhiteSpace(portName))
                {
                    checkBoxConnect.Checked = false;
                    return;
                }

                if (!cnc_connecting()) return; 

                create_new_connection(portName);
            }
            catch (Exception)
            {
                
            }
            finally
            {
                checkBoxConnect.Text = (checkBoxConnect.Checked) ? "Disconnect" : "Connect";
            }
        }

        private void create_new_connection(string portName)
        {
            _gantry = new CncCom(portName);
        }

        private bool cnc_connecting()
        {
            return checkBoxConnect.Checked;
        }

        private void try_close_last_connection()
        {
            try
            {
                _gantry.Dispose();
            }
            catch 
            {
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (!cnc_connecting())
                return;

            _gantry.Reset();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (!cnc_connecting())
                return;

            _gantry.Home();
        }

        private void buttonJogXplus_Click(object sender, EventArgs e)
        {
            if (!cnc_connecting())
                return;

            _gantry.Jog(JogDirection.XPLUS, 5);
        }

        private void buttonJogYplus_Click(object sender, EventArgs e)
        {
            if (!cnc_connecting())
                return;

            _gantry.Jog(JogDirection.YPLUS, 5);
        }

        private void buttonJogYminus_Click(object sender, EventArgs e)
        {
            if (!cnc_connecting())
                return;

            _gantry.Jog(JogDirection.YMINUS, 5);
        }

        private void buttonJogXminus_Click(object sender, EventArgs e)
        {
            if (!cnc_connecting())
                return;

            _gantry.Jog(JogDirection.XMINUS, 5);
        }

        private void buttonJogZplus_Click(object sender, EventArgs e)
        {
            if (!cnc_connecting())
                return;

            _gantry.Jog(JogDirection.ZPLUS, 5);
        }

        private void buttonJogZminus_Click(object sender, EventArgs e)
        {
            if (!cnc_connecting())
                return;

            _gantry.Jog(JogDirection.ZMINUS, 5);
        }

        private void trackBarFeedrate_Scroll(object sender, EventArgs e)
        {
            textBoxFeedRate.Text = trackBarFeedrate.Value.ToString(CultureInfo.InvariantCulture);
        }

    }
}
