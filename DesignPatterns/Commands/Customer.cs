using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Commands
{
    //the receiver
    public class Customer
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool IsVerified { get; set; }
    }
}
