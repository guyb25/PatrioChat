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
            _connection.Send(new Packet(new User("guy"), PacketType.Login));
            _connection.Read();
        }

        public bool Login(string username)
        {
            throw new NotImplementedException();
        }

        public void Logout(string username)
        {
            _connection.Close();
        }

        public bool Register(string username)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
