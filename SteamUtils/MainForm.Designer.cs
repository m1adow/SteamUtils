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
            this.buttonSend = new System.Windows.Forms.Button();
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
            this.textBoxMessage.Size = new System.Drawing.Size(188, 23);
            this.textBoxMessage.TabIndex = 8;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(427, 26);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(84, 15);
            this.labelMessage.TabIndex = 9;
            this.labelMessage.Text = "Write message";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(633, 44);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 23);
            this.textBoxCount.TabIndex = 10;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(633, 24);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(69, 15);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "Write count";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(427, 73);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(306, 47);
            this.buttonSend.TabIndex = 12;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSend);
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
        private Button buttonSend;
    }
}