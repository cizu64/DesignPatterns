using DesignPatterns.Factory.Product;
using System;

namespace DesignPatterns.Factory.Creator
{
    class Soccer
    {
        public ISoccer Create(string className)
        {
            return (ISoccer)Activator.CreateInstance(Type.GetType($"DesignPatterns.Factory.Product.Soccer.{className}"));
        }
    }
}
