using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    //The service interface the proxy follows
    public interface ICart
    {
        decimal Total();
        IList<Product> ListProducts();
    }
}
