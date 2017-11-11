using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL.Entities;
using ACM.BL.Repositories;
using Core.Common;

namespace ACM.BL.Controllers
{
    public class OrderController
    {
        private readonly CustomerRepository _customerRepository;
        private readonly OrderRepository _orderRepository;
        private readonly InventoryRepository _inventoryRepository;
        private readonly EmailLibrary _emailLibrary;

        public OrderController()
        {
            _customerRepository = new CustomerRepository();
            _orderRepository = new OrderRepository();
            _inventoryRepository = new InventoryRepository();
            _emailLibrary = new EmailLibrary();
        }

        public void PlaceOrder(Customer customer, Order order, Payment payment,
                               bool allowSplitOrders, bool emailReceipt)
        {
            _customerRepository.Add(customer);

            _orderRepository.Add(order);

            _inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment();

            if (emailReceipt)
            {
                customer.ValidateEmail();
                _customerRepository.Update();

                _emailLibrary.SendEmail(customer.EmailAddress, "Here is your receipt");
            }
        }
    }
}
