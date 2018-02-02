using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using SAM.Core.HPCNC;

namespace SAM.HPCncForm
{
    public partial class FormStandardControl 
    {
        private void populateComPorts()
        {
            var ports = SerialPort.GetPortNames();
            foreach (var port in ports)
                comboBoxCOM.Items.Add(port);
        }

        private void createNewConnection(string port)
        {
            _cncCom = new CncCom(port);
        }

        private CncInfo receivedInfo;

        private void error(string errorMsg, string exceptionMsg)
        {
            updateStatus(string.Format("Error: {0}. {1}", errorMsg, exceptionMsg));
        }

        private void tryClosePreviousConnection()
        {
            try
            {
                if(_cncCom == null)
                    return;

                _cncCom.Dispose();
            }
            catch (Exception)
            {
            }
        }

        private void updateConnectButtonText()
        {
            buttonConnect.Text = cncConnected ? "Disconnect" : "Connect";
        }

        private void updateStatus(string msg)
        {
            textBoxStatus.Text = msg;
        }

        private void enableReceiving()
        {
            timerUpdate.Enabled = true;
        }

        private void getCncInfo()
        {
            receivedInfo = new CncInfo(Encoding.ASCII.GetString(_cncCom.GetCncInfo().ToArray()));
            extractReceivedInfo();
        }

        private void disableUpdateTimer()
        {
            timerUpdate.Enabled = false;
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

            textBoxCurrentFeedRate.Text = receivedInfo.F;
        }
    }
}