using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublisherSubscriber;
using System;

namespace PublisherSubscriberTest
{

    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void MainTestMethod()
        {
            Publisher<int> PublisherInt = new Publisher<int>();
            Subscriber<int> SubscriberInt = new Subscriber<int>(PublisherInt);
            SubscriberInt.Publisher.PublisherEventHandler += 
                (object sender, PublisherEventArgs<int> e) => { 
                    Console.WriteLine("Callback for publish event on PublisherInt: "+e.Message); 
                };

            Publisher<string> PublisherString = new Publisher<string>();
            Subscriber<string> SubscriberString = new Subscriber<string>(PublisherString);
            SubscriberString.Publisher.PublisherEventHandler += 
                (object sender, PublisherEventArgs<string> e) => {
                    Console.WriteLine("Callback for publish event on PublisherString: " + e.Message);
                };

            Subscriber<string> SubscriberString2 = new Subscriber<string>(PublisherString);
            SubscriberString.Publisher.PublisherEventHandler += Subscriber<string>.SubscriberDelegateFunction;

            PublisherInt.Publish(10);
            PublisherString.Publish("Hello world");
        }
    }
}
