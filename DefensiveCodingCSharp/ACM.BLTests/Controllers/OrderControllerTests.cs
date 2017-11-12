using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL.Entities;
using Core.Common;

namespace ACM.BL.ControllersTests
{
    [TestClass()]
    public class OrderControllerTests
    {
        [TestMethod()]
        public void PlaceOrderTest_Valid()
        {
            // Arrange
            var orderController = new OrderController();
            var customer = new Customer() {EmailAddress = "test@gmail.com"};
            var order = new Order();
            var payment = new Payment {PaymentType = 1};

            // Act
            var opRes = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);

            // Assert
            Assert.AreEqual(true, opRes.Success);
            Assert.AreEqual(0, opRes.MessageList.Count);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlaceOrderTest_Invalid()
        {
            // Arrange
            var orderController = new OrderController();
            Customer customer = null;
            var order = new Order();
            var payment = new Payment { PaymentType = 1 };

            // Act
            var opRes = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);

            // Assert
        }

        [TestMethod()]
        public void PlaceOrderTest_InvalidEmailAddress_ReturnsMessage()
        {
            // Arrange
            var orderController = new OrderController();
            var customer = new Customer() {EmailAddress = ""};
            var order = new Order();
            var payment = new Payment { PaymentType = 1 };

            // Act
            var opRes = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);

            // Assert
            Assert.AreEqual(true, opRes.Success);
            Assert.AreEqual(1, opRes.MessageList.Count);
            Assert.AreEqual("Email address is null", opRes.MessageList[0]);
        }
    }
}