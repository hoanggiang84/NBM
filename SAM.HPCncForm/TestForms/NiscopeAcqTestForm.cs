using System;
using System.Windows.Forms;
using SAM.Core.Nscope;

namespace SAM.HPCncForm.TestForms
{
    public partial class NiscopeAcqTestForm : Form
    {
        public NiscopeAcqTestForm()
        {
            InitializeComponent();
        }

        niScope myScope;
        private void buttonGetData_Click(object sender, EventArgs e)
        {
            try
            {
                var res = textBoxResource.Text;
                var chan = "0";
                double range = 1;
                double rate = 500000000;
                double offset = 0;
                var numSamp = 1000;
                double refPos = 0;
                double timeOut = 5;
                var waveform = new double[numSamp];
                double impedance = 50;
                var coupling = 1;
                var triggerDelay = double.Parse(textBoxTriggerDelay.Text);

                // Configure the Scope's general parameters
                var waveInfo = new niScopeWfmInfo[1];
                myScope = new niScope(res, true, true);
                myScope.ConfigureAcquisition(0);
                myScope.ConfigureVertical(chan, range, offset, coupling, 1, true);
                myScope.ConfigureChanCharacteristics(chan, impedance, -1);
                myScope.ConfigureHorizontalTiming(rate, numSamp, refPos, 1, true);
                //myScope.ConfigureTriggerEdge(chan, 2.0, 0, 1, 0, triggerDelay);

                // Acquire and Read data
                myScope.Read(chan, timeOut, numSamp, waveform, waveInfo);
            }
            catch (Exception ex)
            {
                textBoxStatus.Text = ex.Message;
            }
            finally
            {
                if(myScope != null)
                    myScope.Dispose();
            }

        }
    }
}
