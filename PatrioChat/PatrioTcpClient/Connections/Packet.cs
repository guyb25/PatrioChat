using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrioTcpClient.Connections
{
    [Serializable]
    internal class Packet
    {
        public object Value { get; private set; }
        public PacketType Type { get; private set; }

        public Packet(object value, PacketType type)
        {
            Value = value;
            Type = type;
        }
    }
}
