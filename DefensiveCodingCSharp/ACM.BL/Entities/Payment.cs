using System;
using System.ComponentModel;

namespace ACM.BL.Entities
{
    public partial class Payment
    {
        public int PaymentType { get; set; }

        public void ProcessPayment()
        {
            PaymentTypeOption paymentTypeOption;
            if (!Enum.TryParse(PaymentType.ToString(), out paymentTypeOption))
                throw  new InvalidEnumArgumentException($"Payment type", PaymentType, typeof(PaymentTypeOption));

            switch (paymentTypeOption)
            {
                case PaymentTypeOption.CreditCard:
                    // code
                    break;
                case PaymentTypeOption.PayPal:
                    // code
                    break;
                default:
                    // code
                    break;
            }

        }
    }
}
