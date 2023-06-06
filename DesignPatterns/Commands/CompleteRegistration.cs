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
       

        void ICustomer.Execute()
        {
           
        }
    }
}

