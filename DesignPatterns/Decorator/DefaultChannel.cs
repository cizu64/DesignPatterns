namespace DesignPatterns.Decorator
{
    class DefaultChannel : IAdvert
    {
        public string Broadcast()
        {
            return "Advertising in "+ nameof(DefaultChannel);
        }
    }
}
