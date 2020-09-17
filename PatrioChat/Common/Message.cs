using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Message
    {
        public object Content { get; private set; }
        public Type ContentType { get; private set; }
        public User Sender { get; private set; }
        public DateTime TimeSent { get; private set; }

        public Message(object content, Type contentType, User sender, DateTime timeSent)
        {
            Content = content;
            ContentType = contentType;
            Sender = sender;
            TimeSent = timeSent;
        }
    }
}
