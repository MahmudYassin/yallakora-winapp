namespace yallakora_App
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTeam2 = new System.Windows.Forms.TextBox();
            this.tbTeam2Score = new System.Windows.Forms.TextBox();
            this.tbTeam1Score = new System.Windows.Forms.TextBox();
            this.tbTeam1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboLeague = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboMatch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTeam2 = new System.Windows.Forms.ComboBox();
            this.tbRedCards = new System.Windows.Forms.TextBox();
            this.tbYellowCards = new System.Windows.Forms.TextBox();
            this.tbGoals = new System.Windows.Forms.TextBox();
            this.comboTeam1 = new System.Windows.Forms.ComboBox();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 381);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 59;
            this.label9.Text = "Yellow Card";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 58;
            this.label8.Text = "Red Card";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "Goals";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add match info";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Select a player";
            // 
            // tbTeam2
            // 
            this.tbTeam2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTeam2.Location = new System.Drawing.Point(513, 149);
            this.tbTeam2.Name = "tbTeam2";
            this.tbTeam2.ReadOnly = true;
            this.tbTeam2.Size = new System.Drawing.Size(122, 20);
            this.tbTeam2.TabIndex = 77;
            this.tbTeam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTeam2Score
            // 
            this.tbTeam2Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTeam2Score.Location = new System.Drawing.Point(435, 147);
            this.tbTeam2Score.Name = "tbTeam2Score";
            this.tbTeam2Score.Size = new System.Drawing.Size(26, 20);
            this.tbTeam2Score.TabIndex = 76;
            this.tbTeam2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTeam1Score
            // 
            this.tbTeam1Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTeam1Score.Location = new System.Drawing.Point(364, 147);
            this.tbTeam1Score.Name = "tbTeam1Score";
            this.tbTeam1Score.Size = new System.Drawing.Size(26, 20);
            this.tbTeam1Score.TabIndex = 75;
            this.tbTeam1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTeam1
            // 
            this.tbTeam1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTeam1.Location = new System.Drawing.Point(194, 149);
            this.tbTeam1.Name = "tbTeam1";
            this.tbTeam1.ReadOnly = true;
            this.tbTeam1.Size = new System.Drawing.Size(122, 20);
            this.tbTeam1.TabIndex = 74;
            this.tbTeam1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(161, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 24);
            this.label11.TabIndex = 73;
            this.label11.Text = "Select a league";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(382, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 72;
            this.label10.Text = "Score";
            // 
            // comboLeague
            // 
            this.comboLeague.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLeague.FormattingEnabled = true;
            this.comboLeague.Location = new System.Drawing.Point(352, 9);
            this.comboLeague.Name = "comboLeague";
            this.comboLeague.Size = new System.Drawing.Size(199, 21);
            this.comboLeague.TabIndex = 71;
            this.comboLeague.SelectedIndexChanged += new System.EventHandler(this.comboLeague_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 23);
            this.label6.TabIndex = 70;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(532, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 69;
            this.label5.Text = "Team 2";
            // 
            // comboMatch
            // 
            this.comboMatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMatch.FormattingEnabled = true;
            this.comboMatch.Location = new System.Drawing.Point(352, 62);
            this.comboMatch.Name = "comboMatch";
            this.comboMatch.Size = new System.Drawing.Size(199, 21);
            this.comboMatch.TabIndex = 68;
            this.comboMatch.SelectedIndexChanged += new System.EventHandler(this.comboMatch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 67;
            this.label4.Text = "Select a match";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "Team 1";
            // 
            // comboTeam2
            // 
            this.comboTeam2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTeam2.FormattingEnabled = true;
            this.comboTeam2.Location = new System.Drawing.Point(498, 194);
            this.comboTeam2.Name = "comboTeam2";
            this.comboTeam2.Size = new System.Drawing.Size(151, 21);
            this.comboTeam2.TabIndex = 82;
            this.comboTeam2.SelectedIndexChanged += new System.EventHandler(this.comboTeam2_SelectedIndexChanged);
            this.comboTeam2.Click += new System.EventHandler(this.comboTeam2_Click);
            // 
            // tbRedCards
            // 
            this.tbRedCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRedCards.Location = new System.Drawing.Point(395, 323);
            this.tbRedCards.Name = "tbRedCards";
            this.tbRedCards.Size = new System.Drawing.Size(39, 20);
            this.tbRedCards.TabIndex = 81;
            this.tbRedCards.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbYellowCards
            // 
            this.tbYellowCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbYellowCards.Location = new System.Drawing.Point(395, 284);
            this.tbYellowCards.Name = "tbYellowCards";
            this.tbYellowCards.Size = new System.Drawing.Size(39, 20);
            this.tbYellowCards.TabIndex = 80;
            this.tbYellowCards.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGoals
            // 
            this.tbGoals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbGoals.Location = new System.Drawing.Point(395, 245);
            this.tbGoals.Name = "tbGoals";
            this.tbGoals.Size = new System.Drawing.Size(39, 20);
            this.tbGoals.TabIndex = 79;
            this.tbGoals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboTeam1
            // 
            this.comboTeam1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTeam1.FormattingEnabled = true;
            this.comboTeam1.Location = new System.Drawing.Point(181, 194);
            this.comboTeam1.Name = "comboTeam1";
            this.comboTeam1.Size = new System.Drawing.Size(151, 21);
            this.comboTeam1.TabIndex = 78;
            this.comboTeam1.SelectedIndexChanged += new System.EventHandler(this.comboTeam1_SelectedIndexChanged);
            this.comboTeam1.Click += new System.EventHandler(this.comboTeam1_Click);
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInfo.Location = new System.Drawing.Point(165, 319);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(120, 50);
            this.btnSaveInfo.TabIndex = 83;
            this.btnSaveInfo.Text = "Save";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-3PNIRUL\\SQLEXPRESS;Initial Catalog=project;Integrated Securit" +
    "y=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(552, 319);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 50);
            this.btnConfirm.TabIndex = 84;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.comboTeam2);
            this.Controls.Add(this.tbRedCards);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbYellowCards);
            this.Controls.Add(this.tbGoals);
            this.Controls.Add(this.comboTeam1);
            this.Controls.Add(this.tbTeam2);
            this.Controls.Add(this.tbTeam2Score);
            this.Controls.Add(this.tbTeam1Score);
            this.Controls.Add(this.tbTeam1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboLeague);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboMatch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.AddInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTeam2;
        private System.Windows.Forms.TextBox tbTeam2Score;
        private System.Windows.Forms.TextBox tbTeam1Score;
        private System.Windows.Forms.TextBox tbTeam1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboLeague;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboMatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTeam2;
        private System.Windows.Forms.TextBox tbRedCards;
        private System.Windows.Forms.TextBox tbYellowCards;
        private System.Windows.Forms.TextBox tbGoals;
        private System.Windows.Forms.ComboBox comboTeam1;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Button btnConfirm;
    }
}