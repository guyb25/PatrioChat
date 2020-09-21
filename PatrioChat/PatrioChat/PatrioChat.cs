using PatrioTcpClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrioChat
{
    public partial class PatrioChat : Form
    {
        private IPatriotClient _client;
        private string _username;

        public PatrioChat(IPatriotClient client, string username)
        {
            InitializeComponent();
            _client = client;
            _username = username;
        }

        private void chatsBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chatsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string text = input.Text;
            messagesBox.Items.Add(_username + ": " + text);
        }

        private void messagesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatrioChat_Load(object sender, EventArgs e)
        {

        }
    }
}
