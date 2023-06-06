using System;

namespace DesignPatterns.Factory.Product.Samsung
{
    class A72 : ISamsung
    {
        decimal price = 300;
        public decimal Buy(int quantity)
        {
            return price * quantity;
        }
    }
}
