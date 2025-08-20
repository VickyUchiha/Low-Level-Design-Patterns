using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.Adapter.Adaptee
{
    public class PayPalPayment
    {
        public void MakePayment(int amount, string dollar)
        {
            Console.WriteLine($"Amount received : {amount} , Amount Type : {dollar}");
        }
    }
}
