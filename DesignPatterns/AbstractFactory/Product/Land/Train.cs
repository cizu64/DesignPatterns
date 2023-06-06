using System;

namespace DesignPatterns.AbstractFactory.Product.Land
{
    public class Train : ILand
    {
        public void Deliver()
        {
            Console.WriteLine("Train delivery");
        }
    }
}
