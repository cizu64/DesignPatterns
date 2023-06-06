namespace DesignPatterns.Decorator
{
    public class CNN : AdvertDecorator
    {
        public CNN(IAdvert advert) : base(advert)
        {
        }

        public override string Broadcast()
        {
            return $"{base.Broadcast()} - {nameof(CNN)}";
        }
    }
}
