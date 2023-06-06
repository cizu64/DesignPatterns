using Newtonsoft.Json;
using System;

namespace DesignPatterns.Strategy
{
    //the context class that has a reference to the concrete strategy and communicate only via the stategy interface
    class UserProfile
    {
        IProfile profile;
        public UserProfile(IProfile profile)
        {
            this.profile = profile;
        }
      
        public void AddProfile(object data)
        {
            Console.WriteLine($"Adding {Type.GetType(profile.ToString()).Name}");
             this.profile.AddProfile(data);
           
        }
        public void GetProfile()
        {
            var result = this.profile.GetProfile();
            var json = JsonConvert.SerializeObject(result);
            Console.WriteLine(json);
        }
    }
}
