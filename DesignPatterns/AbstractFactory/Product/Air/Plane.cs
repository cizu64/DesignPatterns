using System;

namespace DesignPatterns.AbstractFactory.Product.Air
{
    public class Plane : IAir
    {
        public void Deliver()
        {
            Console.WriteLine("Plane delivery");
        }
    }
}
