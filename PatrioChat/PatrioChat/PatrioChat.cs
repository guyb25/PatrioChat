using Common;
using Newtonsoft.Json.Linq;
using PatrioTcpClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrioChat
{
    public partial class PatrioChat : Form
    {
        public event Action<int> OnChangeChat;
        public event Action<string> OnSendMessage;
        public event Action OnNewChatButton;

        public PatrioChat()
        {
            InitializeComponent();
            messagesBox.Visible = false;
        }

        public void AddChatRoom(string chatName)
        {
            chatsBox.Items.Add(chatName);
        }

        public void DisplayMessage(Common.Message message)
        {
            messagesBox.Items.Add(message.TimeSent.ToShortTimeString() + " | " + message.Sender + ": " + message.Content.ToString());
        }

        private void chatsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chatIndex = chatsBox.SelectedIndex;
            OnChangeChat?.Invoke(chatIndex);
        }

        public void ChangeChat(Chat newChat)
        {
            messagesBox.Visible = true;
            messagesBox.Items.Clear();

            foreach(Common.Message message in newChat.Messages)
            {
                DisplayMessage(message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            OnSendMessage?.Invoke(input.Text);
            input.Text = string.Empty;
        }

        private void NewChatButton_Click(object sender, EventArgs e)
        {
            OnNewChatButton?.Invoke();
        }

        private void messagesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PatrioChat_Load(object sender, EventArgs e)
        {
        }
        private void chatsBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}