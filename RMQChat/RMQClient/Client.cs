using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;

namespace RMQClient
{
    // USER start
    // THIS STRUCT WILL BE MOVED TO PACKAGE THAT I'LL CREATE LATER. aleks
    struct UserClientInfo 
    {
        readonly Guid UserRoutingKey;
        readonly string Nickname;

        public UserClientInfo(Guid UserRoutingKey, string Nickname)
        {
            this.UserRoutingKey = UserRoutingKey;
            this.Nickname = Nickname;
        }
    }
    // USER end


    static class Client
    {
        // Vars
        private static readonly UserClientInfo UserInfo = new UserClientInfo(Guid.NewGuid(), "placeholder");

        /* Client program user interface "ref"
         * If you want to gather info form UI or change it use this var
         */ 
        private static ClientForm HUD;

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