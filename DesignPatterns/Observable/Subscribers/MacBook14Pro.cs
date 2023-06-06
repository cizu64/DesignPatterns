using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observable.Subscribers
{
    class MacBook14Pro : IStore
    {
        public void Update(string message)
        {
            Console.WriteLine(message);
        }
    }
}
