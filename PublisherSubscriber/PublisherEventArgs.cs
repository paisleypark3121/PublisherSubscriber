using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber
{
    public class PublisherEventArgs<T> : EventArgs
    {
        public T Message { get; set; }

        public PublisherEventArgs(T message)
        {
            Message = message;
        }
    }
}
