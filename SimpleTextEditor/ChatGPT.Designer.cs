namespace SimpleTextEditor
{
    partial class ChatGPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatGPT));
            this.lblSpeech = new System.Windows.Forms.Label();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.chkListen = new System.Windows.Forms.CheckBox();
            this.lblVoice = new System.Windows.Forms.Label();
            this.cbVoice = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtMaxTokens = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSpeech
            // 
            this.lblSpeech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSpeech.AutoSize = true;
            this.lblSpeech.Location = new System.Drawing.Point(11, 312);
            this.lblSpeech.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeech.Name = "lblSpeech";
            this.lblSpeech.Size = new System.Drawing.Size(51, 13);
            this.lblSpeech.TabIndex = 40;
            this.lblSpeech.Text = "speech...";
            this.lblSpeech.Visible = false;
            // 
            // chkMute
            // 
            this.chkMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkMute.AutoSize = true;
            this.chkMute.Location = new System.Drawing.Point(468, 306);
            this.chkMute.Margin = new System.Windows.Forms.Padding(2);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(50, 17);
            this.chkMute.TabIndex = 39;
            this.chkMute.Text = "Mute";
            this.chkMute.UseVisualStyleBackColor = true;
            // 
            // chkListen
            // 
            this.chkListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkListen.AutoSize = true;
            this.chkListen.Location = new System.Drawing.Point(316, 307);
            this.chkListen.Margin = new System.Windows.Forms.Padding(2);
            this.chkListen.Name = "chkListen";
            this.chkListen.Size = new System.Drawing.Size(54, 17);
            this.chkListen.TabIndex = 38;
            this.chkListen.Text = "Listen";
            this.chkListen.UseVisualStyleBackColor = true;
            // 
            // lblVoice
            // 
            this.lblVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVoice.AutoSize = true;
            this.lblVoice.Location = new System.Drawing.Point(558, 307);
            this.lblVoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVoice.Name = "lblVoice";
            this.lblVoice.Size = new System.Drawing.Size(34, 13);
            this.lblVoice.TabIndex = 37;
            this.lblVoice.Text = "Voice";
            // 
            // cbVoice
            // 
            this.cbVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoice.FormattingEnabled = true;
            this.cbVoice.Location = new System.Drawing.Point(597, 306);
            this.cbVoice.Margin = new System.Windows.Forms.Padding(2);
            this.cbVoice.Name = "cbVoice";
            this.cbVoice.Size = new System.Drawing.Size(195, 21);
            this.cbVoice.TabIndex = 36;
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(558, 280);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(36, 13);
            this.Label4.TabIndex = 35;
            this.Label4.Text = "Model";
            // 
            // cbModel
            // 
            this.cbModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Items.AddRange(new object[] {
            "text-davinci-003",
            "text-davinci-002",
            "code-davinci-002"});
            this.cbModel.Location = new System.Drawing.Point(597, 277);
            this.cbModel.Margin = new System.Windows.Forms.Padding(2);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(195, 21);
            this.cbModel.TabIndex = 34;
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(407, 280);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(62, 13);
            this.Label3.TabIndex = 33;
            this.Label3.Text = "Max tokens";
            // 
            // txtMaxTokens
            // 
            this.txtMaxTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaxTokens.Location = new System.Drawing.Point(471, 278);
            this.txtMaxTokens.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxTokens.Name = "txtMaxTokens";
            this.txtMaxTokens.Size = new System.Drawing.Size(68, 20);
            this.txtMaxTokens.TabIndex = 32;
            this.txtMaxTokens.Text = "2048";
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(245, 280);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 13);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "Randomness";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTemperature.Location = new System.Drawing.Point(319, 278);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(68, 20);
            this.txtTemperature.TabIndex = 30;
            this.txtTemperature.Text = "0.5";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(112, 280);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 13);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "User ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUserID.Location = new System.Drawing.Point(159, 278);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(68, 20);
            this.txtUserID.TabIndex = 28;
            this.txtUserID.Text = "1";
            // 
            // txtAnswer
            // 
            this.txtAnswer.AcceptsReturn = true;
            this.txtAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswer.Location = new System.Drawing.Point(8, 34);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnswer.Size = new System.Drawing.Size(784, 223);
            this.txtAnswer.TabIndex = 27;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestion.Location = new System.Drawing.Point(8, 337);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(784, 79);
            this.txtQuestion.TabIndex = 26;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.Location = new System.Drawing.Point(8, 259);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(82, 36);
            this.btnSend.TabIndex = 25;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // ChatGPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSpeech);
            this.Controls.Add(this.chkMute);
            this.Controls.Add(this.chkListen);
            this.Controls.Add(this.lblVoice);
            this.Controls.Add(this.cbVoice);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtMaxTokens);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatGPT";
            this.ShowInTaskbar = false;
            this.Text = "Special Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatGPT_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblSpeech;
        internal System.Windows.Forms.CheckBox chkMute;
        internal System.Windows.Forms.CheckBox chkListen;
        internal System.Windows.Forms.Label lblVoice;
        internal System.Windows.Forms.ComboBox cbVoice;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cbModel;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtMaxTokens;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtTemperature;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtUserID;
        internal System.Windows.Forms.TextBox txtAnswer;
        internal System.Windows.Forms.TextBox txtQuestion;
        internal System.Windows.Forms.Button btnSend;
    }
}