using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrioTcpClient.Connections
{
    internal enum PacketType
    {
        ServerResponse = 0,
        Register = 1,
        Login = 2,
        Logout = 3,
        SendMessage = 4,
        RequestChat = 5        
    }
}
