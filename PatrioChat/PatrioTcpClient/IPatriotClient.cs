using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrioTcpClient
{
    public interface IPatriotClient
    {
        bool Register(string username);
        bool Login(string username);
        void SendMessage(Message message);
    }
}
