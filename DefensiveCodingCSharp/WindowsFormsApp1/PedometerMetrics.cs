using System;
using System.Windows.Forms;
using ACM.BL.Entities;
using NLog;

namespace ACM.Win
{
    public partial class PedometerMetrics : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public PedometerMetrics()
        {
            InitializeComponent();
        }

        private void pedometerCalculateBtn_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            try
            {
                var result = customer.CalculatePercentOfGoalSteps(stepGoalTb.Text, stepsTodayTb.Text);

                Logger.Info($"Goal percentage is calculated.");
                ResultLabel.Text = $"You reached {result:f2}% of your goal!";
            }
            catch (ArgumentException exception)
            {
                Logger.Error(exception.Message + " => " + $"goal: {stepGoalTb.Text}, steps: {stepsTodayTb.Text}\n{exception.StackTrace}");

                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
                ResultLabel.Text = string.Empty;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stepsTodayTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void stepGoalTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
