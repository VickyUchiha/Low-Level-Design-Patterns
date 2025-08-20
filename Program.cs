using DPatterns.Adapter;
using DPatterns.Adapter.Adaptee;
using DPatterns.Adapter.Target;
using DPatterns.Chain_of_Responsibility;
using DPatterns.Chain_of_Responsibility.ConcreteHandlers;

namespace DPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////  ADAPTER PATTERN 

            //IPaymentInterface payment = new PaymentAdapter(new PayPalPayment());
            //payment.Pay(10);
            ////******************************************************************************************************************************************************

            //CHAIN OF RESPONSIBILITY

            //Handler support = new SupportAgent();
            //Handler teamLead = new TeamLead();
            //Handler manager = new Manager();

            ////Create a chain (agent -> teamLead -> manager)
            //support.setNext(teamLead);
            //teamLead.setNext(manager);

            //support.HandleRequest(1);
            //support.HandleRequest(2);
            //support.HandleRequest(3);
        }
    }
}
