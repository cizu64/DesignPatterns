using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class DangoteSalt : DangoteFood
    {
        public override int Quantity { get; set; }
        public override decimal Price { get; set; }
        public override decimal Total { get; set; }
    }
}
