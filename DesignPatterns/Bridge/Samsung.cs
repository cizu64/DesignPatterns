namespace DesignPatterns.Bridge
{
    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class Samsung : IMobile
    {
        string IMobile.getModel(string model)
        {
            return model;
        }

        string IMobile.setColor(Color color)
        {
            return color.ToString();
        }
    }
}
