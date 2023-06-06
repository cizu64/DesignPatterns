using System;

namespace DesignPatterns.AbstractFactory.Product.Air
{
    public class Drone : IAir
    {
        public void Deliver()
        {
            Console.WriteLine("Drone delivery");
        }
    }
}
