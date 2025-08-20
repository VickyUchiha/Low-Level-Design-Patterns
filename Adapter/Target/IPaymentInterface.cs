using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.Adapter.Target
{
    public interface IPaymentInterface
    {
        void Pay(int amount)
        {
        }
    }
}
