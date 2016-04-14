namespace Participation
{
    partial class Hulpvraag
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbRepeat = new System.Windows.Forms.ComboBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbReaction = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dtTill = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Herhalen";
            // 
            // cbRepeat
            // 
            this.cbRepeat.FormattingEnabled = true;
            this.cbRepeat.Items.AddRange(new object[] {
            "Nooit",
            "Dagelijks",
            "Weekenlijks",
            "Maandelijks"});
            this.cbRepeat.Location = new System.Drawing.Point(94, 117);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(231, 21);
            this.cbRepeat.TabIndex = 20;
            this.cbRepeat.Text = "Nooit";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(94, 59);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 20);
            this.dtDate.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Trefwoorden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Titel";
            // 
            // tbTags
            // 
            this.tbTags.Location = new System.Drawing.Point(94, 32);
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(330, 20);
            this.tbTags.TabIndex = 12;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(94, 6);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(330, 20);
            this.tbTitle.TabIndex = 11;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(94, 173);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(330, 177);
            this.tbDescription.TabIndex = 22;
            // 
            // lbReaction
            // 
            this.lbReaction.FormattingEnabled = true;
            this.lbReaction.Location = new System.Drawing.Point(12, 392);
            this.lbReaction.Name = "lbReaction";
            this.lbReaction.Size = new System.Drawing.Size(412, 277);
            this.lbReaction.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Reacties";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 687);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Verzenden";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(15, 687);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(326, 20);
            this.textBox6.TabIndex = 25;
            this.textBox6.Text = "Typ hier Uw bericht";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 713);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Verzenden";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtTill
            // 
            this.dtTill.Location = new System.Drawing.Point(94, 85);
            this.dtTill.Name = "dtTill";
            this.dtTill.Size = new System.Drawing.Size(200, 20);
            this.dtTill.TabIndex = 28;
            // 
            // Hulpvraag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 746);
            this.Controls.Add(this.dtTill);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbReaction);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRepeat);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTags);
            this.Controls.Add(this.tbTitle);
            this.Name = "Hulpvraag";
            this.Text = "Hulpvraag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRepeat;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ListBox lbReaction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtTill;
    }
}