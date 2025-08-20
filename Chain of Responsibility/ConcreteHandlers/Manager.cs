using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.Chain_of_Responsibility.ConcreteHandlers
{
    public class Manager : Handler
    {
        public override void HandleRequest(int requestLevel)
        {
            if (requestLevel == 3)
                Console.WriteLine("Request is handled by Manager");
            else if (nextHandler != null)
                nextHandler.HandleRequest(requestLevel);
        }
    }
}
