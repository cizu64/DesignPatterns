using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public abstract class DangoteFood
    {
        public abstract decimal Total { get; set; }
        public abstract int Quantity { get; set; }
        public abstract decimal Price { get; set; }
    }
}
