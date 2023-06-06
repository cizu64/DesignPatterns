namespace DesignPatterns.Bridge
{
    /// <summary>
    /// The abstraction defines interface in the constructor as the "control" part of other concrete implementations. 
    /// Defines complex business logic
    /// </summary>
    public class Device
    {
        IMobile _mobile;
        public Device(IMobile mobile)
        {
            _mobile = mobile;
        }
        public string GetModel(string model)
        {
            return _mobile.getModel(model.ToString());
        }
        public string Color(Color color)
        {
            return _mobile.setColor(color);
        }
    }
}
