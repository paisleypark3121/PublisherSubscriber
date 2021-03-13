using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    public class Subscriber<T>
    {
        public Publisher<T> Publisher { get; private set; }
        public Subscriber(Publisher<T> publisher)
        {
            Publisher = publisher;
        }

        public static void SubscriberDelegateFunction(object sender, PublisherEventArgs<T> e)
        {
            Console.Write("Here's my delegate: " + e.Message);
        }
    }
}
