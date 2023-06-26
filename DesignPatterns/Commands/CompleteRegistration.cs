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
    public class CompleteRegistration : ICustomer
    {
        private readonly Customer customer;
        private readonly string email;

        public CompleteRegistration(Customer customer, string email)
        {
            this.customer = customer;
            this.email = email;
        }

        void ICustomer.Execute()
        {
            if(customer.Email.Equals(email,StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("customer account verified");
                customer.IsVerified = true;
                var result = JsonConvert.SerializeObject(customer);
                Console.WriteLine(result);
            }
        }
    }
}

