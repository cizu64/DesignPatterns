using System;

namespace DesignPatterns.AbstractFactory.Product.Land
{
    public class Truck : ILand
    {
        public void Deliver()
        {
            Console.WriteLine("Truck delivery");
        }
    }
}
