using PatrioTcpClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrioChat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IPatriotClient patriotClient = new PatriotClient("127.0.0.1", 3000);
            var applicationRunner = new ApplicationRunner(patriotClient);
            applicationRunner.Run();
        }
    }
}
