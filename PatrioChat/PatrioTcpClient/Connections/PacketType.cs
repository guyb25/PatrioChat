using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrioTcpClient.Connections
{
    internal enum PacketType
    {
        Register,
        Login,
        SendMessage,
        RequestChat
    }
}
