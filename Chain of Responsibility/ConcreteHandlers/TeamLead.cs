using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.Chain_of_Responsibility.ConcreteHandlers
{
    public class TeamLead : Handler
    {
        public override void HandleRequest(int requestLevel)
        {
            if (requestLevel == 2)
                Console.WriteLine("Request is handled by Team Lead");
            else if (nextHandler != null)
                nextHandler.HandleRequest(requestLevel);
        }
    }
}
