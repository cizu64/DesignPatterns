using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }


        static IList<Product> GetData()
        {
            var p = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name="Iphone14",
                    Quantity = 1,
                    UnitPrice = 1000
                },
                new Product
                {
                    Id = 2,
                    Name="Macbook Pro",
                    Quantity = 2,
                    UnitPrice = 2000
                },

            };
            return p;
        }

        public static IList<Product> Products { get { return GetData(); } }

    }
}
