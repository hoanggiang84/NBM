using System.Windows.Forms;

namespace SAM.HPCncForm.SAMControl
{
    public partial class CScanForm : Form
    {
        public CScanForm()
        {
            InitializeComponent();
        }

        private void CScanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            e.Cancel = true;
            Hide();
        }
    }
}
