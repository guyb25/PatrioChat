using PatrioChat.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrioChat.Models.Chat
{
    public class Chat
    {
        public ICollection<Message> Messages { get; private set; }
        public string ChatName { get; private set; }
        public Guid ChatId { get; private set; }

        public Chat(ICollection<Message> message, string chatName, Guid chatId)
        {
            Messages = message;
            ChatName = chatName;
            ChatId = chatId;
        }
    }
}
