using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Commands
{
    //the command interface that defines a method for executing a command
    public interface ICustomer
    {
        void Execute();
    }
}
