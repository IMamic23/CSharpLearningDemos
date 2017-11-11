using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.BL.Controllers;
using ACM.BL.Entities;
using ACM.BL.Repositories;
using Core.Common;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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
            orderController.PlaceOrder(customer, order, payment, allowSplitOrders: false, emailReceipt: true);
        }
    }
}
