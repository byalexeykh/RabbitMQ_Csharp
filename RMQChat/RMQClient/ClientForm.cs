using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMQClient
{
    public partial class ClientForm : Form
    {
        // VARS start

        // List of all controlls in "welcome" screen where user sets his nickname and clicks "connect" button
        private List<Control> WelcomeScreen = new List<Control>();
        // List of all controlls in main screen, where user reads and sends messages
        private List<Control> MainScreen = new List<Control>();

        // VARS end

        public ClientForm()
        {
            InitializeComponent();

            // Populating WelcomeScreen with related controls
            WelcomeScreen.Add(btnConnect);
            WelcomeScreen.Add(lblEnterNickname);
            WelcomeScreen.Add(tbNickname);

            // Populating MainScreen with related controls
            MainScreen.Add(gbContacts);
            MainScreen.Add(rtbUserMessage);
            MainScreen.Add(rtbMessagesScreen);
            MainScreen.Add(btnSend);

            ShowWelcomeScreen();
        }

        // CONTROL EVENTS start
        
        /* This class MUST contain only UI related logic (cuz it is much more convenient to keep all "backend" related logic in one place (Client.cs) :) )
         * If UI event should fire some "backend" logic (opening connection, message construction and so on) then assign needed event in Client.cs
         */

        private void tbNickname_TextChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = !string.IsNullOrEmpty(tbNickname.Text);
        }

        // CONTROL EVENTS end

        void ChangeWelcomeScreenVisibility(bool bVisible)
        {
            foreach (Control c in WelcomeScreen)
            {
                c.Visible = bVisible;
            }
        }

        void ChangeMainScreenVisibility(bool bVisible)
        {
            foreach (Control c in MainScreen)
            {
                c.Visible = bVisible;
            }
        }

        public void ShowMainScreen()
        {
            this.Width = 600;

            ChangeWelcomeScreenVisibility(false);
            ChangeMainScreenVisibility(true);
        }

        void ShowWelcomeScreen()
        {
            this.Width = 330;

            ChangeWelcomeScreenVisibility(true);
            ChangeMainScreenVisibility(false);
        }
    }
}
