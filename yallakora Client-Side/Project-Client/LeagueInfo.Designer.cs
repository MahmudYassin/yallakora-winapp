namespace Project_Client
{
    partial class LeagueInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeagueInfo));
            this.selectLeague = new System.Windows.Forms.ComboBox();
            this.leagueLbl = new System.Windows.Forms.Label();
            this.matchList = new System.Windows.Forms.ListView();
            this.Team = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Draws = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Losses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.For = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Against = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Points = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scheduleList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Match = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamsLbl = new System.Windows.Forms.Label();
            this.scheduleLbl = new System.Windows.Forms.Label();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectLeague
            // 
            this.selectLeague.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLeague.FormattingEnabled = true;
            this.selectLeague.Location = new System.Drawing.Point(109, 36);
            this.selectLeague.Margin = new System.Windows.Forms.Padding(2);
            this.selectLeague.Name = "selectLeague";
            this.selectLeague.Size = new System.Drawing.Size(183, 21);
            this.selectLeague.TabIndex = 0;
            this.selectLeague.SelectedIndexChanged += new System.EventHandler(this.selectLeague_SelectedIndexChanged);
            // 
            // leagueLbl
            // 
            this.leagueLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leagueLbl.AutoSize = true;
            this.leagueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leagueLbl.Location = new System.Drawing.Point(31, 31);
            this.leagueLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leagueLbl.Name = "leagueLbl";
            this.leagueLbl.Size = new System.Drawing.Size(74, 24);
            this.leagueLbl.TabIndex = 1;
            this.leagueLbl.Text = "League";
            // 
            // matchList
            // 
            this.matchList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.matchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Team,
            this.Wins,
            this.Draws,
            this.Losses,
            this.For,
            this.Against,
            this.Points});
            this.matchList.HideSelection = false;
            this.matchList.Location = new System.Drawing.Point(35, 111);
            this.matchList.Margin = new System.Windows.Forms.Padding(2);
            this.matchList.Name = "matchList";
            this.matchList.Size = new System.Drawing.Size(400, 239);
            this.matchList.TabIndex = 2;
            this.matchList.UseCompatibleStateImageBehavior = false;
            this.matchList.View = System.Windows.Forms.View.Details;
            this.matchList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.matchList_MouseClick);
            // 
            // Team
            // 
            this.Team.Text = "Team";
            this.Team.Width = 100;
            // 
            // Wins
            // 
            this.Wins.Text = "Wins";
            this.Wins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wins.Width = 50;
            // 
            // Draws
            // 
            this.Draws.Text = "Draws";
            this.Draws.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Draws.Width = 50;
            // 
            // Losses
            // 
            this.Losses.Text = "Losses";
            this.Losses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Losses.Width = 50;
            // 
            // For
            // 
            this.For.Text = "For";
            this.For.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.For.Width = 50;
            // 
            // Against
            // 
            this.Against.Text = "Against";
            this.Against.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Against.Width = 50;
            // 
            // Points
            // 
            this.Points.Text = "Points";
            this.Points.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Points.Width = 50;
            // 
            // scheduleList
            // 
            this.scheduleList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scheduleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Match});
            this.scheduleList.FullRowSelect = true;
            this.scheduleList.HideSelection = false;
            this.scheduleList.Location = new System.Drawing.Point(452, 111);
            this.scheduleList.Margin = new System.Windows.Forms.Padding(2);
            this.scheduleList.Name = "scheduleList";
            this.scheduleList.Size = new System.Drawing.Size(212, 239);
            this.scheduleList.TabIndex = 3;
            this.scheduleList.UseCompatibleStateImageBehavior = false;
            this.scheduleList.View = System.Windows.Forms.View.Details;
            this.scheduleList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.scheduleList_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // Match
            // 
            this.Match.Text = "Match";
            this.Match.Width = 212;
            // 
            // teamsLbl
            // 
            this.teamsLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teamsLbl.AutoSize = true;
            this.teamsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsLbl.Location = new System.Drawing.Point(31, 80);
            this.teamsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamsLbl.Name = "teamsLbl";
            this.teamsLbl.Size = new System.Drawing.Size(68, 24);
            this.teamsLbl.TabIndex = 4;
            this.teamsLbl.Text = "Teams";
            // 
            // scheduleLbl
            // 
            this.scheduleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scheduleLbl.AutoSize = true;
            this.scheduleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleLbl.Location = new System.Drawing.Point(448, 80);
            this.scheduleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scheduleLbl.Name = "scheduleLbl";
            this.scheduleLbl.Size = new System.Drawing.Size(91, 24);
            this.scheduleLbl.TabIndex = 5;
            this.scheduleLbl.Text = "Schedule";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-MR0AN74\\SQLEXPRESS;Initial Catalog=project;Integrated Securit" +
    "y=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(167, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click on team name for info";
            // 
            // LeagueInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduleLbl);
            this.Controls.Add(this.teamsLbl);
            this.Controls.Add(this.scheduleList);
            this.Controls.Add(this.matchList);
            this.Controls.Add(this.leagueLbl);
            this.Controls.Add(this.selectLeague);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LeagueInfo";
            this.Text = "League Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectLeague;
        private System.Windows.Forms.Label leagueLbl;
        private System.Windows.Forms.ListView matchList;
        private System.Windows.Forms.ListView scheduleList;
        private System.Windows.Forms.Label teamsLbl;
        private System.Windows.Forms.Label scheduleLbl;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Team;
        private System.Windows.Forms.ColumnHeader Wins;
        private System.Windows.Forms.ColumnHeader Draws;
        private System.Windows.Forms.ColumnHeader Losses;
        private System.Windows.Forms.ColumnHeader For;
        private System.Windows.Forms.ColumnHeader Against;
        private System.Windows.Forms.ColumnHeader Points;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Match;
    }
}

