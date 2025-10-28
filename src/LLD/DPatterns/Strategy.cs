using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.src.LLD.DPatterns
{
    public class Strategy
    {
        public static void NotMain(string[] args)
        {
            var paymentStrategy = new PaymentStrategy(new BankTransfer());
            paymentStrategy.Pay(100);
            paymentStrategy = new PaymentStrategy(new CreditCard());
            paymentStrategy.Pay(100);
        }
    }

    public interface IPaymentProcessor
    {
        void Pay(double amount);
    }

    public class BankTransfer : IPaymentProcessor
    {
        public void Pay(double amount)
        {
            Logger.Instance.Log($"Paying {amount} by Bank Transfer");
        }
    }

    public class CreditCard : IPaymentProcessor
    {
        public void Pay(double amount)
        {
            Logger.Instance.Log($"Paying {amount} by Credit Card");
        }
    }

    public class PaymentStrategy
    {
        private readonly IPaymentProcessor _paymentProcessor;
        public PaymentStrategy(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }
        public void Pay(double amount)
        {
            _paymentProcessor.Pay(amount);
        }
    }
}
