namespace DesignPatterns.Builder
{
    public class Profile
    {
        public Profile(IProfileBuilder profileBuilder)
        {
        }

        public string Fullname{get;set;}
        public string Gender{get;set;}
        public int Age{get;set;}
    }
}
