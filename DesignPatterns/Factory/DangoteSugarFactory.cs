using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    abstract class DangoteSugarFactory : DangoteFactory
    {
        public override DangoteFood GetFood()
        {
            return new DangoteSugar();
        }
    }
}
