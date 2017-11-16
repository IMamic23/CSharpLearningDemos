using System;
using System.Threading;
using System.Windows.Forms;
using NLog.Config;
using NLog.Targets;
using NLog;

namespace ACM.Win
{
    static class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptionHandler);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);

            var config = new LoggingConfiguration();
            var fileTarget = new FileTarget();

            config.AddTarget("log", fileTarget);
            fileTarget.FileName = "${basedir}/log.txt";
            fileTarget.Layout = @"${date:format=dd\.MM\.yyyy. HH\:mm\:ss} [${level}] [${logger}] ${message}";
            fileTarget.ArchiveAboveSize = long.Parse("10000");

            var rule = new LoggingRule("*", LogLevel.Debug, fileTarget);
            config.LoggingRules.Add(rule);

            LogManager.Configuration = config;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PedometerMetrics());
        }

        private static void GlobalExceptionHandler(object sender, EventArgs e)
        {
            // Log The issue
            Logger.Error(e.ToString());
            MessageBox.Show($"There was a problem...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
