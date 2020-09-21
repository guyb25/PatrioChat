using Common;
using PatrioTcpClient.Connections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PatrioTcpClient
{
    public class PatriotClient : IPatriotClient
    {
        private IConnection<Packet> _connection;

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

        public bool Logout(string username)
        {
            var user = new User(username);
            var packet = new Packet(user, PacketType.Logout);
            _connection.Send(packet);

            var resultPacket = _connection.Read();
            return resultPacket.Type == PacketType.ServerResponse && (bool)resultPacket.Value == true;
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
            var packet = new Packet(message, PacketType.SendMessage);
            _connection.Send(packet);
        }

        public void Close()
        {
            _connection.Close();
        }
    }
}
