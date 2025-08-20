using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.Chain_of_Responsibility
{
    public abstract class Handler
    {
        protected Handler nextHandler;
        public abstract void HandleRequest(int requestLevel);
        public void setNext( Handler handler)
        {
            nextHandler = handler;
        }
    }
}
