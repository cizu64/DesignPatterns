using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    interface IProfile
    {
        object AddProfile(object data);
        object GetProfile();
    }
}
