using Common;
using System;
using System.Text;

namespace PatrioTcpClient.Connections
{
    internal interface IConnection<T>
    {
        event Action<Packet> OnMessage;
        void Send(T packet);
        T Read();
        void Close();
        void Listen();
    }
}
