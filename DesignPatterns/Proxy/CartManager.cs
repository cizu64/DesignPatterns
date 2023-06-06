using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    //the client
    public class CartManager
    {
        private readonly ICart _cart;

        public CartManager(ICart cart)
        {
            _cart = cart;
        }
        public string DisplayCartProductsAndFinalTotal()
        {
            
            var products = _cart.ListProducts();
            var total = _cart.Total();

            var result = JsonConvert.SerializeObject(new { products, total });
            return result;
        }
    }
}
