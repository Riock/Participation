namespace Participation.Forms
{
    partial class MainAdmin
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
            this.gbQuestions = new System.Windows.Forms.GroupBox();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lbQuestions = new System.Windows.Forms.ListBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblResultaten = new System.Windows.Forms.Label();
            this.btnNewuser = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbQuestions.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbQuestions
            // 
            this.gbQuestions.Controls.Add(this.lbQuestions);
            this.gbQuestions.Controls.Add(this.btnFilter);
            this.gbQuestions.Location = new System.Drawing.Point(13, 13);
            this.gbQuestions.Name = "gbQuestions";
            this.gbQuestions.Size = new System.Drawing.Size(388, 406);
            this.gbQuestions.TabIndex = 0;
            this.gbQuestions.TabStop = false;
            this.gbQuestions.Text = "Hulpvragen";
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.btnSearch);
            this.gbUsers.Controls.Add(this.btnNewuser);
            this.gbUsers.Controls.Add(this.lblResultaten);
            this.gbUsers.Controls.Add(this.tbSearch);
            this.gbUsers.Controls.Add(this.lblSearch);
            this.gbUsers.Controls.Add(this.lbResults);
            this.gbUsers.Location = new System.Drawing.Point(419, 13);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(394, 406);
            this.gbUsers.TabIndex = 1;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Gebruikers";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(265, 20);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Filters";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // lbQuestions
            // 
            this.lbQuestions.FormattingEnabled = true;
            this.lbQuestions.Location = new System.Drawing.Point(7, 82);
            this.lbQuestions.Name = "lbQuestions";
            this.lbQuestions.Size = new System.Drawing.Size(375, 316);
            this.lbQuestions.TabIndex = 1;
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(13, 84);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(375, 316);
            this.lbResults.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(7, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Zoek op naam";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(90, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(298, 20);
            this.tbSearch.TabIndex = 4;
            // 
            // lblResultaten
            // 
            this.lblResultaten.AutoSize = true;
            this.lblResultaten.Location = new System.Drawing.Point(13, 65);
            this.lblResultaten.Name = "lblResultaten";
            this.lblResultaten.Size = new System.Drawing.Size(58, 13);
            this.lblResultaten.TabIndex = 5;
            this.lblResultaten.Text = "Resultaten";
            // 
            // btnNewuser
            // 
            this.btnNewuser.Location = new System.Drawing.Point(130, 54);
            this.btnNewuser.Name = "btnNewuser";
            this.btnNewuser.Size = new System.Drawing.Size(105, 23);
            this.btnNewuser.TabIndex = 6;
            this.btnNewuser.Text = "Nieuwe gebruiker";
            this.btnNewuser.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(256, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Zoek";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 431);
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.gbQuestions);
            this.Name = "MainAdmin";
            this.Text = "MainAdmin";
            this.gbQuestions.ResumeLayout(false);
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQuestions;
        private System.Windows.Forms.ListBox lbQuestions;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.Button btnNewuser;
        private System.Windows.Forms.Label lblResultaten;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnSearch;
    }
}