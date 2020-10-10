using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatrioTcpClient
{
    public interface IPatriotClient
    {
        bool Register(string username);
        bool Login(string username);
        void RequestChats(string username);
        void SendMessage(Message message);
        void Logout(string username);
        void CreateNewChat(string chatName, IEnumerable<User> participants);
        void RequestUsers();
        void Listen(Action<Packet> onMessage);
        void Close();
    }
}
