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
        public MessageType ContentType { get; private set; }
        public string Sender { get; private set; }
        public string TargetRoomId { get; private set; }
        public DateTime TimeSent { get; private set; }

        public Message(object content, MessageType contentType, string sender, string targetRoomId, DateTime timeSent)
        {
            Content = content;
            ContentType = contentType;
            Sender = sender;
            TargetRoomId = targetRoomId;
            TimeSent = timeSent;
        }
    }
}
