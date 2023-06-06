namespace DesignPatterns.Bridge
{
    /// <summary>
    /// Concret implementation
    /// </summary>
    public class Redmi : IMobile
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
