using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    //The concrete strategy class that implements the strategy interface and several algorithm that the context uses 
    class JobProfile : IProfile
    {
        List<object> items = null;
        object IProfile.AddProfile(object data)
        {
            items = new List<object>
            {
                data
            };
            return items;
        }

        object IProfile.GetProfile()
        {
            return items ?? new List<object>();
        }
    }
}