using Newtonsoft.Json;
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
        private Stream _stream;
        private TcpClient _client;

        public Connection(string hostname, int port)
        {
            _client = new TcpClient();
            _client.Connect(hostname, port);
            _stream = _client.GetStream();
        }

        public void Send(Packet packet)
        {
            string jsonPacket = JsonConvert.SerializeObject(packet);
            byte[] message = Encoding.Default.GetBytes(jsonPacket);
            _stream.Write(message, 0, jsonPacket.Length);
        }

        public async Task<Packet> Read()
        {
            var reader = new StreamReader(_stream);
            string message = string.Empty;

            while (reader.Peek() != -1)
            {
                message += Convert.ToChar(reader.Read());
            }
            
            return (Packet) JsonConvert.DeserializeObject(message);
        }

        public void Close()
        {
            _client.Close();
        }
    }
}
