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
    public partial class Login : Form
    {
        public event Action<string> OnLogin;
        private IPatriotClient _client;

        public Login(IPatriotClient client)
        {
            InitializeComponent();
            _client = client;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            bool success = _client.Register(username);

            if (success)
            {
                this.serverMessageLabel.Text = "Registered!";
            }

            else
            {
                this.serverMessageLabel.Text = "Failed to register.";
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            bool success = _client.Login(username);

            if (success)
            {
                OnLogin?.Invoke(username);
            }

            else
            {
                this.serverMessageLabel.Text = "Failed to log in.";
            }
        }
    }
}
