using System;
using ACM.BL.Entities;
using Core.Common;

namespace ACM.BL.Repositories
{
    public class CustomerRepository
    {
        public OperationResult Add(Customer customer)
        {
            var opRes = new OperationResult();

            opRes.Success = true;
            opRes.MessageList.Add($"Customer {customer.FirstName} {customer.LastName} with email address {customer.EmailAddress} is successfully added");

            return opRes;
        }

        public void Update()
        {
           // imagine code
        }
    }
}
