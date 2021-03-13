using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    public class Publisher<T>
    {
        public event EventHandler<PublisherEventArgs<T>> PublisherEventHandler;

        protected virtual void OnPublish(PublisherEventArgs<T> args)
        {
            var handler = PublisherEventHandler;

            if (handler != null)
                handler(this, args);
        }

        public void Publish(T data)
        {
            PublisherEventArgs<T> message = 
                (PublisherEventArgs<T>)Activator.CreateInstance(
                    typeof(PublisherEventArgs<T>), 
                    new object[] { data });
            OnPublish(message);
        }
    }
}
