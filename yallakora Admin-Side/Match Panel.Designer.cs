namespace yallakora_App
{
    partial class Match
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Match));
            this.MatchDate = new System.Windows.Forms.DateTimePicker();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.comboTeam2 = new System.Windows.Forms.ComboBox();
            this.comboTeam1 = new System.Windows.Forms.ComboBox();
            this.comboLeague = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatchDate
            // 
            this.MatchDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MatchDate.CustomFormat = "YYYY-MM-DD HH:MI:SS";
            this.MatchDate.Location = new System.Drawing.Point(351, 239);
            this.MatchDate.Name = "MatchDate";
            this.MatchDate.Size = new System.Drawing.Size(190, 20);
            this.MatchDate.TabIndex = 56;
            // 
            // comboStatus
            // 
            this.comboStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(351, 180);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(190, 21);
            this.comboStatus.TabIndex = 55;
            this.comboStatus.SelectedIndexChanged += new System.EventHandler(this.comboStatus_SelectedIndexChanged);
            // 
            // comboTeam2
            // 
            this.comboTeam2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTeam2.FormattingEnabled = true;
            this.comboTeam2.Location = new System.Drawing.Point(444, 113);
            this.comboTeam2.Name = "comboTeam2";
            this.comboTeam2.Size = new System.Drawing.Size(154, 21);
            this.comboTeam2.TabIndex = 54;
            this.comboTeam2.SelectedIndexChanged += new System.EventHandler(this.comboTeam2_SelectedIndexChanged);
            // 
            // comboTeam1
            // 
            this.comboTeam1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTeam1.FormattingEnabled = true;
            this.comboTeam1.Location = new System.Drawing.Point(228, 111);
            this.comboTeam1.Name = "comboTeam1";
            this.comboTeam1.Size = new System.Drawing.Size(154, 21);
            this.comboTeam1.TabIndex = 53;
            this.comboTeam1.SelectedIndexChanged += new System.EventHandler(this.comboTeam1_SelectedIndexChanged);
            // 
            // comboLeague
            // 
            this.comboLeague.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLeague.FormattingEnabled = true;
            this.comboLeague.Location = new System.Drawing.Point(360, 13);
            this.comboLeague.Name = "comboLeague";
            this.comboLeague.Size = new System.Drawing.Size(190, 21);
            this.comboLeague.TabIndex = 52;
            this.comboLeague.SelectedIndexChanged += new System.EventHandler(this.comboLeague_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(189, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 51;
            this.label7.Text = "Match status :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 24);
            this.label6.TabIndex = 50;
            this.label6.Text = "VS";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 49;
            this.label5.Text = "Team 2";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Select a league:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Team 1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Match date:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 342);
            this.panel1.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add a new match";
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMatch.Location = new System.Drawing.Point(536, 280);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(120, 50);
            this.btnAddMatch.TabIndex = 58;
            this.btnAddMatch.Text = "Add";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click_1);
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
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 342);
            this.Controls.Add(this.btnAddMatch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MatchDate);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.comboTeam2);
            this.Controls.Add(this.comboTeam1);
            this.Controls.Add(this.comboLeague);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Match";
            this.Text = "Match";
            this.Load += new System.EventHandler(this.AddMatchForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker MatchDate;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox comboTeam2;
        private System.Windows.Forms.ComboBox comboTeam1;
        private System.Windows.Forms.ComboBox comboLeague;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}