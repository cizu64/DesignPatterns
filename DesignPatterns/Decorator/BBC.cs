namespace DesignPatterns.Decorator
{
    public class BBC : AdvertDecorator
    {
        public BBC(IAdvert advert) : base(advert)
        {
        }

        public override string Broadcast()
        {
            return $"{base.Broadcast()} - {nameof(BBC)}";
        }
    }
}
