using DesignPatterns.Factory.Product;
using System;

namespace DesignPatterns.Factory.Creator
{
    class Samsung
    {
        public ISamsung Create(string className)
        {
            return (ISamsung)Activator.CreateInstance(Type.GetType($"DesignPatterns.Factory.Product.Samsung.{className}"));
        }
    }
}
