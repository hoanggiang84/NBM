using System;
using System.Windows.Forms;
using SAM.HPCncForm.DataProcessing;
using SAM.HPCncForm.SAMControl;

namespace SAM.HPCncForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AScanForm());
        }
    }
}
