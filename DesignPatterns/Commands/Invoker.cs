using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Commands
{
    //sends a request to the command or Triggers the command
    public class Invoker
    {
        private readonly ICustomer customer; //the command interface

        public Invoker(ICustomer customer)
        {
            this.customer = customer;
        }
        public void Trigger()
        {
            customer.Execute();
        }
    }
}
