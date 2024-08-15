namespace DesignPatterns.Builder
{
    public interface IProfileBuilder
    {
        IProfileBuilder SetFullname(string fullname);
        IProfileBuilder SetAge(int age);
        IProfileBuilder SetGender(string gender);
        Profile Build();
    }
}
