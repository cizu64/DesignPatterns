using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Product.Soccer
{
    class HW : ISoccer
    {
        public string Outcome(int homeScore, int awayScore)
        {
            return awayScore < homeScore ? "Home team wins" : "";
        }
    }
}
