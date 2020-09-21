using Common;
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
        public event Action<Packet> OnMessage;
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

        public Packet Read()
        {
            var reader = new StreamReader(_stream);
            string message = string.Empty;

            while (reader.Peek() != -1)
            {
                message += Convert.ToChar(reader.Read());
            }
            
            return JsonConvert.DeserializeObject<Packet>(message);
        }

        public void Listen()
        {
            while (_client.Connected)
            {
                try
                {
                    var packet = Read();
                    OnMessage?.Invoke(packet);
                }

                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void Close()
        {
            _client.Close();
        }
    }
}
