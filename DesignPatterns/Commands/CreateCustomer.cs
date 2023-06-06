using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Commands
{
    //The concrete command that delegates the work to other object
    public class CreateCustomer : ICustomer
    {
        private readonly Customer customer;
        public CreateCustomer(Customer customer)
        {
            this.customer = customer;
        }

        void ICustomer.Execute()
        {
            Console.WriteLine("customer created");
            var result = JsonConvert.SerializeObject(customer);
            Console.WriteLine(result);
        }
    }
}
