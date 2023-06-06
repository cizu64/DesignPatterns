namespace DesignPatterns.Decorator
{
    public abstract class AdvertDecorator : IAdvert
    {
        IAdvert _advert;
        public AdvertDecorator(IAdvert advert)
        {
            _advert = advert;
        }

        public virtual string Broadcast()
        {
            return _advert.Broadcast();
        }
    }
}
