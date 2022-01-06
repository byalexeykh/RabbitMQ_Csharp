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

        /* Client program user interface "ref"
         * If you want to gather info form UI or change it use this var
         */
        public static ClientForm HUD;
        private static readonly HUDEventHandler UIEventHandler = new HUDEventHandler();
        private static UserClientInfo? UserInfo = null;

        // VARS end

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HUD = new ClientForm();

            // Assigning events from UI
            // If some UI controls are inaccessible then go to From designer, select needed UI element and change its Properties->Modifiers to Public
            HUD.btnConnect.Click += UIEventHandler.btnConnect_Click;

            Application.Run(HUD);
            // Everything after "Application.Run(HUD);" will run after user close application, cuz WinForm uses loop (idk is it safe to write smth after "Run")
        }

        public static void InitializeUserInfo(string UserNickname)
        {
            if (UserInfo != null)
                return;

            UserInfo = new UserClientInfo(Guid.NewGuid(), UserNickname);
        }

        public static void OpenConnection()
        {
            // RabbitMQ connectionFactory and other funny staff
        }
    }

    class HUDEventHandler
    {
        public void btnConnect_Click(object sender, EventArgs e)
        {
            Client.InitializeUserInfo(Client.HUD.btnConnect.Text);
            Client.OpenConnection();
            Client.HUD.ShowMainScreen();
        }
    }
}