using Common;
using System;
using System.Collections.Generic;

namespace PatrioTcpClient
{
    public class PatriotClient : IPatriotClient
    {
        private Connection _connection;

        public PatriotClient(string hostname, int port)
        {
            _connection = new Connection(hostname, port);
        }

        public bool Login(string username)
        {
            var user = new User(username);
            var packet = new Packet(user, PacketType.Login);
            _connection.Send(packet);

            var resultPacket = _connection.Read();
            return resultPacket.Type == PacketType.ServerResponse && (bool) resultPacket.Value == true;
        }

        public void Logout(string username)
        {
            var user = new User(username);
            var packet = new Packet(user, PacketType.Logout);
            _connection.Send(packet);
        }

        public bool Register(string username)
        {
            var user = new User(username);
            var packet = new Packet(user, PacketType.Register);
            _connection.Send(packet);

            var resultPacket = _connection.Read();
            return resultPacket.Type == PacketType.ServerResponse && (bool) resultPacket.Value == true;
        }

        public void Listen(Action<Packet> onMessage)
        {
            _connection.OnMessage += onMessage;
            _connection.Listen();
        }

        public void SendMessage(Message message)
        {
            var packet = new Packet(message, PacketType.NewMessage);
            _connection.Send(packet);
        }

        public void RequestChats(string username)
        {
            var user = new User(username);
            var packet = new Packet(user, PacketType.RequestChats);
            _connection.Send(packet);
        }

        public void CreateNewChat(string chatName, IEnumerable<User> participants)
        {
            var chatCreationRequest = new ChatCreationRequest(chatName, participants);
            var packet = new Packet(chatCreationRequest, PacketType.NewChat);
            _connection.Send(packet);
        }

        public void RequestUsers()
        {
            var packet = new Packet(null, PacketType.RequestUsers);
            _connection.Send(packet);
        }

        public void Close()
        {
            _connection.Close();
        }
    }
}
