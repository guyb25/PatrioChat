using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrioTcpClient.Connections
{
    internal interface IConnection<T>
    {
        void Send(T packet);
        Task<T> Read();
        void Close();
    }
}
