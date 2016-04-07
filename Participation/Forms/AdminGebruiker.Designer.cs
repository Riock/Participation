namespace Participation.Forms
{
    partial class AdminGebruiker
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
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDateofbirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProfilepicture = new System.Windows.Forms.Label();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.gbContent = new System.Windows.Forms.GroupBox();
            this.lbQuestion = new System.Windows.Forms.ListBox();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.gbProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProfile
            // 
            this.gbProfile.Controls.Add(this.pbPicture);
            this.gbProfile.Controls.Add(this.lblProfilepicture);
            this.gbProfile.Controls.Add(this.textBox3);
            this.gbProfile.Controls.Add(this.textBox2);
            this.gbProfile.Controls.Add(this.textBox1);
            this.gbProfile.Controls.Add(this.lblRole);
            this.gbProfile.Controls.Add(this.lblDateofbirth);
            this.gbProfile.Controls.Add(this.lblName);
            this.gbProfile.Location = new System.Drawing.Point(13, 13);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(479, 189);
            this.gbProfile.TabIndex = 0;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "Profiel";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(10, 89);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(23, 13);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Rol";
            // 
            // lblDateofbirth
            // 
            this.lblDateofbirth.AutoSize = true;
            this.lblDateofbirth.Location = new System.Drawing.Point(10, 55);
            this.lblDateofbirth.Name = "lblDateofbirth";
            this.lblDateofbirth.Size = new System.Drawing.Size(80, 13);
            this.lblDateofbirth.TabIndex = 1;
            this.lblDateofbirth.Text = "Geboortedatum";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Naam";
            // 
            // lblProfilepicture
            // 
            this.lblProfilepicture.AutoSize = true;
            this.lblProfilepicture.Location = new System.Drawing.Point(324, 16);
            this.lblProfilepicture.Name = "lblProfilepicture";
            this.lblProfilepicture.Size = new System.Drawing.Size(54, 13);
            this.lblProfilepicture.TabIndex = 6;
            this.lblProfilepicture.Text = "Profielfoto";
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(327, 32);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(146, 149);
            this.pbPicture.TabIndex = 7;
            this.pbPicture.TabStop = false;
            // 
            // gbContent
            // 
            this.gbContent.Controls.Add(this.lbChat);
            this.gbContent.Controls.Add(this.lbQuestion);
            this.gbContent.Location = new System.Drawing.Point(13, 209);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(479, 200);
            this.gbContent.TabIndex = 1;
            this.gbContent.TabStop = false;
            this.gbContent.Text = "Content";
            // 
            // lbQuestion
            // 
            this.lbQuestion.FormattingEnabled = true;
            this.lbQuestion.Location = new System.Drawing.Point(7, 20);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(220, 173);
            this.lbQuestion.TabIndex = 0;
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.Location = new System.Drawing.Point(258, 19);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(215, 173);
            this.lbChat.TabIndex = 1;
            // 
            // AdminGebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 421);
            this.Controls.Add(this.gbContent);
            this.Controls.Add(this.gbProfile);
            this.Name = "AdminGebruiker";
            this.Text = "AdminGebruiker";
            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProfile;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDateofbirth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label lblProfilepicture;
        private System.Windows.Forms.GroupBox gbContent;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.ListBox lbQuestion;
    }
}