using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrioChat
{
    public class ChatsManager
    {
        private List<Chat> _chats;
        public List<User> Users { get; private set; }

        public ChatsManager()
        {
            _chats = new List<Chat>();
            Users = new List<User>();
        }

        public void AddChat(Chat chat)
        {
            _chats.Add(chat);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void AddMessageToChat(string chatId, Message message)
        {
            var chat = FindChatById(chatId);
            chat.Messages.Add(message);
        }

        public IEnumerable<Message> GetChatMessages(string chatId)
        {
            return FindChatById(chatId).Messages;
        }

        public Chat FindChatByIndex(int index)
        {
            return _chats[index];
        }

        private Chat FindChatById(string chatId)
        {
            return _chats.Find(chat => chat.ChatId == chatId);
        }
    }
}
