using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ChatCreationRequest
    {
        public string ChatName;
        public IEnumerable<User> Participants;

        public ChatCreationRequest(string chatName, IEnumerable<User> participants)
        {
            ChatName = chatName;
            Participants = participants;
        }
    }
}
