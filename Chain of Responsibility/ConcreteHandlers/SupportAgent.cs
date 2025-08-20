using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.Chain_of_Responsibility.ConcreteHandlers
{
    public class SupportAgent : Handler
    {
        public override void HandleRequest(int requestLevel)
        {
            if (requestLevel == 1)
                Console.WriteLine("Request is handled by Support Agent");
            else if (nextHandler != null)
                nextHandler.HandleRequest(requestLevel);
        }
    }
}
