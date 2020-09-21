using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum PacketType
    {
        ServerResponse = 0,
        Register = 1,
        Login = 2,
        Logout = 3,
        SendMessage = 4,
        NewChat = 5,
        ReceiveMessage = 6
    }
}
