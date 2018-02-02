namespace SAM.HPCncForm.DataProcessing
{
    public partial class DataProcessForm
    {
        private void stopProcessingData()
        {
            processing = false;
            timerScan.Enabled = false;
            buttonStart.Text = "Start";
            indexAScan = 500;
            indexBScan = 0;
            bSamples.Clear();
        }

        private void configureBScanGraph()
        {
            var myPane = zedGraphControlBSCAN.GraphPane;

            myPane.Title.Text = "B SCAN";
            myPane.YAxis.Title.Text = "Sample";
            myPane.XAxis.Title.Text = "Record";

            myPane.XAxis.Scale.MajorStep = 500;
            myPane.YAxis.Scale.MajorStep = 100;
            myPane.XAxis.Scale.Max = 2500;
            myPane.XAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 0;
            myPane.YAxis.Scale.Min = -500;
        }

        private void configureAScanGraph()
        {
            var myPane = zedGraphControlASCAN.GraphPane;

            myPane.Title.Text = "A SCAN";
            myPane.YAxis.Title.Text = "Amplitude(V)";
            myPane.XAxis.Title.Text = "Sample";

            myPane.XAxis.Scale.MajorStep = 50;
            myPane.YAxis.Scale.MajorStep = 0.2;
            myPane.XAxis.Scale.Max = 500;
            myPane.XAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 0.35;
            myPane.YAxis.Scale.Min = -0.25;
        }
    }
}