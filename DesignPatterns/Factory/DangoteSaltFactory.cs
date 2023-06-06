using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class DangoteSaltFactory : DangoteFactory
    {
        public override DangoteFood GetFood()
        {
            return new DangoteSalt();
        }
    }
}
