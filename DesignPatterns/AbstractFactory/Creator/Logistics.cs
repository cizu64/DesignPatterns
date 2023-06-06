using DesignPatterns.AbstractFactory.Product.Air;
using DesignPatterns.AbstractFactory.Product.Land;
using System;

namespace DesignPatterns.AbstractFactory.Creator
{
    class Logistics
    {
        public ILand CreateLandTransport(string className)
        {
            return (ILand)Activator.CreateInstance(Type.GetType($"DesignPatterns.AbstractFactory.Product.Land.{className}"));
        }

        public IAir CreateAirTransport(string className)
        {
            return (IAir)Activator.CreateInstance(Type.GetType($"DesignPatterns.AbstractFactory.Product.Air.{className}"));
        }


    }
}
