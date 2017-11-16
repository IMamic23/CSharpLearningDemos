using System;
using System.Windows.Forms;
using ACM.BL.Controllers;
using ACM.BL.Entities;
using NLog;

namespace ACM.Win
{
    public partial class Form1 : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public Form1()
        {
            InitializeComponent();
        }

        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private static void PlaceOrder()
        {
            var customer = new Customer
            {
                CustimerId = 1,
                FirstName = "Ivica",
                LastName = "Mamic",
                EmailAddress = "m.ivica@gmail.com"
            };

            var order = new Order();
            // populate order

            var payment = new Payment();
            // populate payment info

            var orderController = new OrderController();
            try
            {
                var opRes = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: false, emailReceipt: true);
            }
            catch (ArgumentNullException ex)
            {
                // log the issue
                Logger.Error(ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show(@"Order was not succesfull, please try again.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
