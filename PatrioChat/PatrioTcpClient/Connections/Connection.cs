using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PatrioTcpClient.Connections
{
    internal class Connection : IConnection<Packet>
    {
        private IFormatter _formatter;
        private Stream _stream;
        private TcpClient _client;

        public Connection(IFormatter formatter, string hostname, int port)
        {
            _formatter = formatter;

            _client = new TcpClient();
            _client.Connect(hostname, port);
            _stream = _client.GetStream();
        }

        public void Send(Packet packet)
        {
            _formatter.Serialize(_stream, packet);
        }

        public Packet Read()
        {
            return (Packet)_formatter.Deserialize(_stream);
        }

        public void Close()
        {
            _client.Close();
        }
    }
}
