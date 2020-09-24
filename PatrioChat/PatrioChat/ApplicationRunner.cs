using Common;
using Newtonsoft.Json.Linq;
using PatrioTcpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrioChat
{
    public class ApplicationRunner
    {
        private IPatriotClient _client;

        public ApplicationRunner(IPatriotClient client)
        {
            _client = client;
        }

        public void Run()
        {
            string clientUsername = string.Empty;
            bool loggedIn = false;

            var loginScreen = new Login(_client);
            loginScreen.OnLogin += (username) =>
            {
                loginScreen.Close();
                clientUsername = username;
                loggedIn = true;
            };

            Application.Run(loginScreen);

            if (loggedIn)
            {
                var patrioChatUI = new PatrioChat();
                var patrioChatManager = new PatrioChatManager(patrioChatUI, _client, clientUsername);

                Application.Run(patrioChatUI);

                _client.Logout(clientUsername);
            }

            _client.Close();
        }
    }
}
