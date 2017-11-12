using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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

        public OperationResult PlaceOrder(Customer customer, Order order, Payment payment,
                               bool allowSplitOrders, bool emailReceipt)
        {
            Debug.Assert(_customerRepository != null, "Missing customer repository instance");
            Debug.Assert(_orderRepository != null, "Missing order repository instance");
            Debug.Assert(_inventoryRepository != null, "Missing inventory repositoy instance");
            Debug.Assert(_emailLibrary != null, "Missing email library instance");

            if (customer == null)
                throw new ArgumentNullException($"Customer instance is null");
            if (order == null)
                throw new ArgumentNullException($"Order instance is null");
            if (payment == null)
                throw new ArgumentNullException($"Payment instance is null");

            var opRes = new OperationResult();

            var addCustResult = _customerRepository.Add(customer);
            if (!addCustResult.Success)
            {
                opRes.Success = false;
                opRes.MessageList.AddRange(addCustResult.MessageList);
            }

            _orderRepository.Add(order);

            _inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment();

            if (emailReceipt)
            {
                var result = customer.ValidateEmail();

                if (result.Success)
                {
                    _customerRepository.Update();
                    _emailLibrary.SendEmail(customer.EmailAddress, "Here is your receipt");
                }
                else
                {
                    // log the messages
                    if (result.MessageList.Any())
                    {
                        foreach (var message in result.MessageList)
                            opRes.AddMessage(message);
                    }
                }
            }

            return opRes;
        }
    }
}
