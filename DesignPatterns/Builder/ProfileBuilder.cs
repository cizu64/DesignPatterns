using Newtonsoft.Json;

namespace DesignPatterns.Builder
{
    public class ProfileBuilder : IProfileBuilder
    {
        Profile profile; //the profile
        public ProfileBuilder()
        {
            profile = new Profile(this);
        }
       
        public Profile Build()
        {
            return profile;
        }
    
        public IProfileBuilder SetAge(int age)
        {
            profile.Age=age;
            return this;
        }
    
        public IProfileBuilder SetFullname(string fullname)
        {
            profile.Fullname=fullname;
            return this;
        }
    
        public IProfileBuilder SetGender(string gender)
        {
            profile.Gender=gender;
            return this;    
        }
    }
}
