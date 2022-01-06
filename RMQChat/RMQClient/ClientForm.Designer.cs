namespace RMQClient
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblEnterNickname = new System.Windows.Forms.Label();
            this.rtbMessagesScreen = new System.Windows.Forms.RichTextBox();
            this.gbContacts = new System.Windows.Forms.GroupBox();
            this.rtbUserMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNickname
            // 
            this.tbNickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNickname.Location = new System.Drawing.Point(54, 345);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(215, 20);
            this.tbNickname.TabIndex = 0;
            this.tbNickname.Text = "xXx=EHOT_B_TATTKAX=xXx";
            this.tbNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNickname.TextChanged += new System.EventHandler(this.tbNickname_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnect.Location = new System.Drawing.Point(119, 370);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // lblEnterNickname
            // 
            this.lblEnterNickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEnterNickname.AutoSize = true;
            this.lblEnterNickname.Location = new System.Drawing.Point(116, 328);
            this.lblEnterNickname.Name = "lblEnterNickname";
            this.lblEnterNickname.Size = new System.Drawing.Size(81, 13);
            this.lblEnterNickname.TabIndex = 2;
            this.lblEnterNickname.Text = "Enter nickname";
            this.lblEnterNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbMessagesScreen
            // 
            this.rtbMessagesScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessagesScreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbMessagesScreen.Location = new System.Drawing.Point(205, 39);
            this.rtbMessagesScreen.Name = "rtbMessagesScreen";
            this.rtbMessagesScreen.ReadOnly = true;
            this.rtbMessagesScreen.Size = new System.Drawing.Size(369, 210);
            this.rtbMessagesScreen.TabIndex = 3;
            this.rtbMessagesScreen.Text = "";
            this.rtbMessagesScreen.Visible = false;
            // 
            // gbContacts
            // 
            this.gbContacts.Location = new System.Drawing.Point(13, 33);
            this.gbContacts.Name = "gbContacts";
            this.gbContacts.Size = new System.Drawing.Size(185, 270);
            this.gbContacts.TabIndex = 4;
            this.gbContacts.TabStop = false;
            this.gbContacts.Text = "Contacts";
            this.gbContacts.Visible = false;
            // 
            // rtbUserMessage
            // 
            this.rtbUserMessage.Location = new System.Drawing.Point(205, 256);
            this.rtbUserMessage.Name = "rtbUserMessage";
            this.rtbUserMessage.Size = new System.Drawing.Size(317, 47);
            this.rtbUserMessage.TabIndex = 5;
            this.rtbUserMessage.Text = "";
            this.rtbUserMessage.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(528, 256);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(46, 47);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 451);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbUserMessage);
            this.Controls.Add(this.gbContacts);
            this.Controls.Add(this.rtbMessagesScreen);
            this.Controls.Add(this.lblEnterNickname);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbNickname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.Text = "RMQClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label lblEnterNickname;
        private System.Windows.Forms.RichTextBox rtbMessagesScreen;
        private System.Windows.Forms.GroupBox gbContacts;
        public System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox rtbUserMessage;
        private System.Windows.Forms.Button btnSend;
    }
}

