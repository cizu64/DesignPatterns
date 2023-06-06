namespace DesignPatterns.Bridge
{
    /// <summary>
    /// The implementation defines interface for all implementing class.
    /// </summary>
    public interface IMobile
    {
        string setColor(Color color);
        string getModel(string model);
    }
}
