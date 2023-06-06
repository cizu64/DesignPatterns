using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observable
{
    //the subscriber interface that pulishers uses to work with subscribers via the interface
    interface IStore 
    {
        void Update(string message); //updates from publishers. Can have parameters
    }
}
