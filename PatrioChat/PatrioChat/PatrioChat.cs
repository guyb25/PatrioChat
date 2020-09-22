using Common;
using Newtonsoft.Json.Linq;
using PatrioTcpClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrioChat
{
    public partial class PatrioChat : Form
    {
        private IPatriotClient _client;
        private string _username;

        private ChatsManager _chatsManager;
        private Chat _scopedChat;

        public PatrioChat(IPatriotClient client, string username)
        {
            InitializeComponent();
            _client = client;
            _username = username;
            _chatsManager = new ChatsManager();

            Task.Run(() => _client.Listen((packet) => onMessage(packet)));
            _client.RequestChats(_username);
        }

        private void onMessage(Packet packet)
        {
            switch(packet.Type)
            {
                case PacketType.NewChat:
                    Invoke((MethodInvoker)delegate
                    {
                        var chat = ((JObject)packet.Value).ToObject<Chat>();
                        chatsBox.Items.Add(chat.ChatName);
                        _chatsManager.AddChat(chat);
                    });
                    break;

                case PacketType.NewMessage:
                    Invoke((MethodInvoker)delegate
                    {
                        var message = ((JObject)packet.Value).ToObject<Common.Message>();
                        _chatsManager.AddMessageToChat(message.TargetRoomId, message);
                        DisplayMessage(message);
                    });
                    break;
            }
        }

        private void DisplayMessage(Common.Message message)
        {
            if (_scopedChat != null)
            {
                messagesBox.Items.Add(message.Sender + ": " + message.Content.ToString());
            }
        }

        private void chatsBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void chatsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chatIndex = chatsBox.SelectedIndex;

            if (chatIndex != -1)
            {
                _scopedChat = _chatsManager.FindChatByIndex(chatIndex);

                messagesBox.Items.Clear();
                foreach (Common.Message message in _scopedChat.Messages)
                {
                    DisplayMessage(message);
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (_scopedChat != null)
            {
                string text = input.Text;
                var message = new Common.Message(text, MessageType.Text, _username, _scopedChat.ChatId, DateTime.Now);
                _client.SendMessage(message);
            }
        }

        private void messagesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PatrioChat_Load(object sender, EventArgs e)
        {
        }
    }
}
