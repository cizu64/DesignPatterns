using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    //The proxy implements the service interface and pass the service object in the constructor
    public class DiscountProxy : ICart
    {
        Cart _cart;
        public decimal DiscountPercent { get; set; } = 5; //default is 5
        public bool EnableDiscount { get; set; } = true;
        public DiscountProxy(Cart cart)
        {
            _cart = cart;
        }
        public decimal Total()
        {
            //can do something before or after the service object code executes
            var products = _cart.ListProducts();
            var total = products.Sum(p => p.UnitPrice * p.Quantity);
            if (EnableDiscount)
            {
                var discountedTotal = total - ((total * DiscountPercent) / 100);
                return discountedTotal;
            }
            return total;
        }

        public IList<Product> ListProducts()
        {
            return _cart.ListProducts();
        }
    }
}
