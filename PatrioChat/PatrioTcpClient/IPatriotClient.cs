using Common;
using System;
using System.Text;

namespace PatrioTcpClient
{
    public interface IPatriotClient
    {
        bool Register(string username);
        bool Login(string username);
        void SendMessage(Message message);
        bool Logout(string username);
        void Listen(Action<Packet> onMessage);
        void Close();
    }
}
