using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;
using RMQChatLib;

namespace RMQClient
{
    static class Client
    {
        // VARS start

        private static readonly UserClientInfo UserInfo = new UserClientInfo(Guid.NewGuid(), "xXx=EHOT_B_TATTKAX=xXx");

        /* Client program user interface "ref"
         * If you want to gather info form UI or change it use this var
         */ 
        private static ClientForm HUD;

        // VARS end

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HUD = new ClientForm();
            Application.Run(HUD);

        }
    }
}