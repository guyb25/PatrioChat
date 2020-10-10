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

namespace PatrioTcpClient
{
    internal class Connection
    {
        public event Action<Packet> OnMessage;
        private Stream _stream;
        private StreamReader _reader;
        private TcpClient _client;

        private int MESSAGE_LENGTH_SIZE = 5;

        public Connection(string hostname, int port)
        {
            _client = new TcpClient();
            _client.Connect(hostname, port);
            _stream = _client.GetStream();
            _reader = new StreamReader(_stream);
        }

        public void Send(Packet packet)
        {
            string jsonPacket = JsonConvert.SerializeObject(packet);
            byte[] message = Encoding.Default.GetBytes(jsonPacket);
            _stream.Write(message, 0, jsonPacket.Length);
        }

        public Packet Read()
        {
            char[] lengthString = new char[MESSAGE_LENGTH_SIZE];
            _reader.ReadBlock(lengthString, 0, MESSAGE_LENGTH_SIZE);

            int length = Convert.ToInt32(new string(lengthString));
            char[] message = new char[length];
            _reader.ReadBlock(message, 0, length);
            
            return JsonConvert.DeserializeObject<Packet>(new string(message));
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
