using DesignPatterns.AbstractFactory.Product.Land;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observable.Publisher
{
    //the publisher publishes events to objects (subscribers) of interests. Publishers allows subscribers subscribe and unsubscribe for events.
    class StoreManager
    {
        List<IStore> subscribers;
        public StoreManager()
        {
            subscribers = new List<IStore>();
        }
        public void Subscribe(IStore store)
        {
            subscribers.Add(store);
        }
        public void UnSubscribe(IStore store)
        {
            subscribers.Remove(store);
        }
        public void NotifySubscribers(string[] availableBrands)
        {
            foreach (var sub in subscribers)
            {
                var ab = availableBrands.Where(b => b == sub.ToString()).ToList();
                ab.ForEach((b) =>
                {
                    sub.Update($"The {Type.GetType(b).Name} is available");
                });
            }
        }
    }

}
