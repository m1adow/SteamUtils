namespace SteamUtils
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserState = new System.Windows.Forms.Label();
            this.comboBoxGame = new System.Windows.Forms.ComboBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.buttonInvite = new System.Windows.Forms.Button();
            this.radioButtonSendMessage = new System.Windows.Forms.RadioButton();
            this.radioButtonSendInviteToGame = new System.Windows.Forms.RadioButton();
            this.labelMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(741, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(39, 15);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "Name";
            // 
            // labelUserState
            // 
            this.labelUserState.AutoSize = true;
            this.labelUserState.Location = new System.Drawing.Point(746, 24);
            this.labelUserState.Name = "labelUserState";
            this.labelUserState.Size = new System.Drawing.Size(33, 15);
            this.labelUserState.TabIndex = 4;
            this.labelUserState.Text = "State";
            // 
            // comboBoxGame
            // 
            this.comboBoxGame.FormattingEnabled = true;
            this.comboBoxGame.Items.AddRange(new object[] {
            "Dota 2",
            "CS:GO",
            "Apex Legends"});
            this.comboBoxGame.Location = new System.Drawing.Point(667, 415);
            this.comboBoxGame.Name = "comboBoxGame";
            this.comboBoxGame.Size = new System.Drawing.Size(121, 23);
            this.comboBoxGame.TabIndex = 5;
            this.comboBoxGame.SelectedIndexChanged += new System.EventHandler(this.comboBoxGame_SelectedIndexChanged);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 15;
            this.listBoxFriends.Location = new System.Drawing.Point(12, 24);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(397, 409);
            this.listBoxFriends.TabIndex = 6;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Location = new System.Drawing.Point(12, 6);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(72, 15);
            this.labelFriends.TabIndex = 7;
            this.labelFriends.Text = "Select friend";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(427, 44);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(306, 23);
            this.textBoxMessage.TabIndex = 8;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(427, 24);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(84, 15);
            this.labelMessage.TabIndex = 9;
            this.labelMessage.Text = "Write message";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(427, 85);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 23);
            this.textBoxCount.TabIndex = 10;
            this.textBoxCount.Text = "1";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(427, 67);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(69, 15);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "Write count";
            // 
            // buttonMessage
            // 
            this.buttonMessage.Location = new System.Drawing.Point(551, 84);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(57, 23);
            this.buttonMessage.TabIndex = 12;
            this.buttonMessage.Text = "Send";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(633, 85);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(100, 23);
            this.textBoxDelay.TabIndex = 13;
            this.textBoxDelay.Text = "0";
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(633, 67);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(66, 15);
            this.labelDelay.TabIndex = 14;
            this.labelDelay.Text = "Write delay";
            // 
            // buttonInvite
            // 
            this.buttonInvite.Location = new System.Drawing.Point(551, 85);
            this.buttonInvite.Name = "buttonInvite";
            this.buttonInvite.Size = new System.Drawing.Size(57, 23);
            this.buttonInvite.TabIndex = 15;
            this.buttonInvite.Text = "Invite";
            this.buttonInvite.UseVisualStyleBackColor = true;
            this.buttonInvite.Click += new System.EventHandler(this.buttonInvite_Click);
            // 
            // radioButtonSendMessage
            // 
            this.radioButtonSendMessage.AutoSize = true;
            this.radioButtonSendMessage.Location = new System.Drawing.Point(427, 416);
            this.radioButtonSendMessage.Name = "radioButtonSendMessage";
            this.radioButtonSendMessage.Size = new System.Drawing.Size(100, 19);
            this.radioButtonSendMessage.TabIndex = 16;
            this.radioButtonSendMessage.TabStop = true;
            this.radioButtonSendMessage.Text = "Send message";
            this.radioButtonSendMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonSendMessage.UseVisualStyleBackColor = true;
            this.radioButtonSendMessage.CheckedChanged += new System.EventHandler(this.radioButtonSendMessage_CheckedChanged);
            // 
            // radioButtonSendInviteToGame
            // 
            this.radioButtonSendInviteToGame.AutoSize = true;
            this.radioButtonSendInviteToGame.Location = new System.Drawing.Point(533, 416);
            this.radioButtonSendInviteToGame.Name = "radioButtonSendInviteToGame";
            this.radioButtonSendInviteToGame.Size = new System.Drawing.Size(130, 19);
            this.radioButtonSendInviteToGame.TabIndex = 17;
            this.radioButtonSendInviteToGame.TabStop = true;
            this.radioButtonSendInviteToGame.Text = "Send invite to game";
            this.radioButtonSendInviteToGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonSendInviteToGame.UseVisualStyleBackColor = true;
            this.radioButtonSendInviteToGame.CheckedChanged += new System.EventHandler(this.radioButtonSendInviteToGame_CheckedChanged);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(496, 398);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(81, 15);
            this.labelMode.TabIndex = 18;
            this.labelMode.Text = "Choose mode";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.radioButtonSendInviteToGame);
            this.Controls.Add(this.radioButtonSendMessage);
            this.Controls.Add(this.buttonInvite);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.textBoxDelay);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.comboBoxGame);
            this.Controls.Add(this.labelUserState);
            this.Controls.Add(this.labelUserName);
            this.Name = "MainForm";
            this.Text = "SteamUtils";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelUserName;
        private Label labelUserState;
        private ComboBox comboBoxGame;
        private ListBox listBoxFriends;
        private Label labelFriends;
        private TextBox textBoxMessage;
        private Label labelMessage;
        private TextBox textBoxCount;
        private Label labelCount;
        private Button buttonMessage;
        private TextBox textBoxDelay;
        private Label labelDelay;
        private Button buttonInvite;
        private RadioButton radioButtonSendMessage;
        private RadioButton radioButtonSendInviteToGame;
        private Label labelMode;
    }
}