using System;
using System.Windows.Forms;
using ACM.BL.Entities;

namespace ACM.Win
{
    public partial class PedometerMetrics : Form
    {
        public PedometerMetrics()
        {
            InitializeComponent();
        }

        private void pedometerCalculateBtn_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            var result = customer.CalculatePercentOfGoalSteps(stepGoalTb.Text, stepsTodayTb.Text);

            ResultLabel.Text = $"You reached {result:f2}% of your goal!";
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
