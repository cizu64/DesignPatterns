using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observable.Subscribers
{
    //concrete subscribers must implement the same interface so publishers are not tightly coupled to concerete classes
     class Samsung_S22_Ultra : IStore
    {
        public void Update(string message)
        {
            Console.WriteLine(message);
        }
    }
}
