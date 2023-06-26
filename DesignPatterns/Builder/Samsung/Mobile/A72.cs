using DesignPatterns.Builder.Samsung.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Samsung.Mobile
{
    public class A72 : ISamsung
    {
        public string SetModel(string model)
        {
            return model;
        }

        public string SetSimtype(SIM type)
        {
            return type.ToString();
        }

        public string SetUSBType(USB type)
        {
            return type.ToString();
        }
    }
}
