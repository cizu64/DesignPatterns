using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static DesignPatterns.Mediator.Components.Category;

namespace DesignPatterns.Proxy
{
    //the service object implement the service interface
    public class Cart : ICart
    {
        public decimal Total()
        {
            var total = ListProducts().Sum(p => p.UnitPrice * p.Quantity);
            return total;
        }
        public IList<Product> ListProducts()
        {
            return Product.Products;
        }
    }
}
