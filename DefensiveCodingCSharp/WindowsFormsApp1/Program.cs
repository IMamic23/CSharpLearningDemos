using System;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ACM.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptionHandler);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PedometerMetrics());
        }

        private static void GlobalExceptionHandler(object sender, EventArgs e)
        {
            // Log The issue
            MessageBox.Show($"There was a problem...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
