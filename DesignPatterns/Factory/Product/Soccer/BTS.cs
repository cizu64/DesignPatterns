using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Product.Soccer
{
    class BTS : ISoccer
    {
        public string Outcome(int homeScore, int awayScore)
        {
            return ((awayScore > 0 && homeScore > 0) ? "Both teams socred" : "");
        }
    }
}
