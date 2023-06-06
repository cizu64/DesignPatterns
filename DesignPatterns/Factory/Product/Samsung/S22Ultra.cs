using System;

namespace DesignPatterns.Factory.Product.Samsung
{
    class S22Ultra : ISamsung
    {
        decimal price = 1000;
        public decimal Buy(int quantity)
        {
            return price * quantity;
        }
    }
}
