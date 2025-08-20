using DPatterns.Adapter.Adaptee;
using DPatterns.Adapter.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.Adapter
{
    public class PaymentAdapter : IPaymentInterface
    {
        private readonly PayPalPayment _payPalPayment;
        public PaymentAdapter(PayPalPayment payPalPayment) 
        {
            _payPalPayment = payPalPayment;
        }

        public void Pay(int amount)
        {
            //Adapter transaltes Pay -> MakePayment
            _payPalPayment.MakePayment(amount, "$");
        }
    }
}
