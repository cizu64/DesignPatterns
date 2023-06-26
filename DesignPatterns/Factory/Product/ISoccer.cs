using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Product
{
    interface ISoccer
    {
        string Outcome(int homeScore, int awayScore);
    }
}
