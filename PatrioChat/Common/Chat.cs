using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Chat
    {
        public ICollection<Message> Messages { get; private set; }
        public string ChatName { get; private set; }
        public string ChatId { get; private set; }

        public Chat(ICollection<Message> messages, string chatName, string chatId)
        {
            Messages = messages;
            ChatName = chatName;
            ChatId = chatId;
        }
    }
}
