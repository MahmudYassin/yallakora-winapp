namespace Project_Client
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
            this.teamTxt1 = new System.Windows.Forms.TextBox();
            this.teamTxt2 = new System.Windows.Forms.TextBox();
            this.goalsTxt1 = new System.Windows.Forms.TextBox();
            this.goalsTxt2 = new System.Windows.Forms.TextBox();
            this.yellowTxt1 = new System.Windows.Forms.TextBox();
            this.yellowTxt2 = new System.Windows.Forms.TextBox();
            this.redTxt1 = new System.Windows.Forms.TextBox();
            this.redTxt2 = new System.Windows.Forms.TextBox();
            this.teamLbl1 = new System.Windows.Forms.Label();
            this.teamLbl2 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.Label();
            this.goalsLbl = new System.Windows.Forms.Label();
            this.yellowLbl = new System.Windows.Forms.Label();
            this.redLbl = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamTxt1
            // 
            this.teamTxt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teamTxt1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.teamTxt1.Location = new System.Drawing.Point(377, 121);
            this.teamTxt1.Margin = new System.Windows.Forms.Padding(2);
            this.teamTxt1.Name = "teamTxt1";
            this.teamTxt1.ReadOnly = true;
            this.teamTxt1.Size = new System.Drawing.Size(163, 23);
            this.teamTxt1.TabIndex = 1;
            this.teamTxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teamTxt2
            // 
            this.teamTxt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teamTxt2.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.teamTxt2.Location = new System.Drawing.Point(593, 121);
            this.teamTxt2.Margin = new System.Windows.Forms.Padding(2);
            this.teamTxt2.Name = "teamTxt2";
            this.teamTxt2.ReadOnly = true;
            this.teamTxt2.Size = new System.Drawing.Size(163, 23);
            this.teamTxt2.TabIndex = 2;
            this.teamTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goalsTxt1
            // 
            this.goalsTxt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goalsTxt1.Location = new System.Drawing.Point(498, 201);
            this.goalsTxt1.Margin = new System.Windows.Forms.Padding(2);
            this.goalsTxt1.Name = "goalsTxt1";
            this.goalsTxt1.ReadOnly = true;
            this.goalsTxt1.Size = new System.Drawing.Size(25, 20);
            this.goalsTxt1.TabIndex = 5;
            this.goalsTxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goalsTxt2
            // 
            this.goalsTxt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goalsTxt2.Location = new System.Drawing.Point(613, 201);
            this.goalsTxt2.Margin = new System.Windows.Forms.Padding(2);
            this.goalsTxt2.Name = "goalsTxt2";
            this.goalsTxt2.ReadOnly = true;
            this.goalsTxt2.Size = new System.Drawing.Size(25, 20);
            this.goalsTxt2.TabIndex = 6;
            this.goalsTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yellowTxt1
            // 
            this.yellowTxt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yellowTxt1.Location = new System.Drawing.Point(498, 266);
            this.yellowTxt1.Margin = new System.Windows.Forms.Padding(2);
            this.yellowTxt1.Name = "yellowTxt1";
            this.yellowTxt1.ReadOnly = true;
            this.yellowTxt1.Size = new System.Drawing.Size(25, 20);
            this.yellowTxt1.TabIndex = 7;
            this.yellowTxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yellowTxt2
            // 
            this.yellowTxt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yellowTxt2.Location = new System.Drawing.Point(613, 266);
            this.yellowTxt2.Margin = new System.Windows.Forms.Padding(2);
            this.yellowTxt2.Name = "yellowTxt2";
            this.yellowTxt2.ReadOnly = true;
            this.yellowTxt2.Size = new System.Drawing.Size(25, 20);
            this.yellowTxt2.TabIndex = 8;
            this.yellowTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // redTxt1
            // 
            this.redTxt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redTxt1.Location = new System.Drawing.Point(498, 329);
            this.redTxt1.Margin = new System.Windows.Forms.Padding(2);
            this.redTxt1.Name = "redTxt1";
            this.redTxt1.ReadOnly = true;
            this.redTxt1.Size = new System.Drawing.Size(25, 20);
            this.redTxt1.TabIndex = 9;
            this.redTxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // redTxt2
            // 
            this.redTxt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redTxt2.Location = new System.Drawing.Point(613, 329);
            this.redTxt2.Margin = new System.Windows.Forms.Padding(2);
            this.redTxt2.Name = "redTxt2";
            this.redTxt2.ReadOnly = true;
            this.redTxt2.Size = new System.Drawing.Size(25, 20);
            this.redTxt2.TabIndex = 10;
            this.redTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teamLbl1
            // 
            this.teamLbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teamLbl1.AutoSize = true;
            this.teamLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLbl1.Location = new System.Drawing.Point(419, 86);
            this.teamLbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamLbl1.Name = "teamLbl1";
            this.teamLbl1.Size = new System.Drawing.Size(74, 24);
            this.teamLbl1.TabIndex = 11;
            this.teamLbl1.Text = "Team 1";
            // 
            // teamLbl2
            // 
            this.teamLbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teamLbl2.AutoSize = true;
            this.teamLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLbl2.Location = new System.Drawing.Point(634, 86);
            this.teamLbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamLbl2.Name = "teamLbl2";
            this.teamLbl2.Size = new System.Drawing.Size(74, 24);
            this.teamLbl2.TabIndex = 12;
            this.teamLbl2.Text = "Team 2";
            // 
            // results
            // 
            this.results.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.results.AutoSize = true;
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(528, 158);
            this.results.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(80, 24);
            this.results.TabIndex = 13;
            this.results.Text = "Statistics";
            // 
            // goalsLbl
            // 
            this.goalsLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goalsLbl.AutoSize = true;
            this.goalsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalsLbl.Location = new System.Drawing.Point(390, 203);
            this.goalsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goalsLbl.Name = "goalsLbl";
            this.goalsLbl.Size = new System.Drawing.Size(58, 24);
            this.goalsLbl.TabIndex = 14;
            this.goalsLbl.Text = "Goals";
            // 
            // yellowLbl
            // 
            this.yellowLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yellowLbl.AutoSize = true;
            this.yellowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLbl.Location = new System.Drawing.Point(354, 266);
            this.yellowLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yellowLbl.Name = "yellowLbl";
            this.yellowLbl.Size = new System.Drawing.Size(120, 24);
            this.yellowLbl.TabIndex = 15;
            this.yellowLbl.Text = "Yellow Cards";
            // 
            // redLbl
            // 
            this.redLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redLbl.AutoSize = true;
            this.redLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLbl.Location = new System.Drawing.Point(367, 329);
            this.redLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLbl.Name = "redLbl";
            this.redLbl.Size = new System.Drawing.Size(99, 24);
            this.redLbl.TabIndex = 16;
            this.redLbl.Text = "Red Cards";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-3PNIRUL\\SQLEXPRESS;Initial Catalog=project;Integrated Securit" +
    "y=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // statusTxt
            // 
            this.statusTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusTxt.Location = new System.Drawing.Point(486, 378);
            this.statusTxt.Margin = new System.Windows.Forms.Padding(2);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.ReadOnly = true;
            this.statusTxt.Size = new System.Drawing.Size(167, 20);
            this.statusTxt.TabIndex = 17;
            this.statusTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTxt
            // 
            this.dateTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTxt.Location = new System.Drawing.Point(486, 426);
            this.dateTxt.Margin = new System.Windows.Forms.Padding(2);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.ReadOnly = true;
            this.dateTxt.Size = new System.Drawing.Size(167, 20);
            this.dateTxt.TabIndex = 18;
            this.dateTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(388, 373);
            this.statusLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(60, 24);
            this.statusLbl.TabIndex = 19;
            this.statusLbl.Text = "Status";
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(390, 422);
            this.dateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(48, 24);
            this.dateLbl.TabIndex = 20;
            this.dateLbl.Text = "Date";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(737, 378);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(120, 50);
            this.closeBtn.TabIndex = 21;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 457);
            this.panelMenu.TabIndex = 22;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblAdmin);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.LightGray;
            this.lblAdmin.Location = new System.Drawing.Point(48, 30);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(108, 26);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "YallaKora";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(680, 80);
            this.panelTitleBar.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(303, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 26);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Match Info";
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.redLbl);
            this.Controls.Add(this.yellowLbl);
            this.Controls.Add(this.goalsLbl);
            this.Controls.Add(this.results);
            this.Controls.Add(this.teamLbl2);
            this.Controls.Add(this.teamLbl1);
            this.Controls.Add(this.redTxt2);
            this.Controls.Add(this.redTxt1);
            this.Controls.Add(this.yellowTxt2);
            this.Controls.Add(this.yellowTxt1);
            this.Controls.Add(this.goalsTxt2);
            this.Controls.Add(this.goalsTxt1);
            this.Controls.Add(this.teamTxt2);
            this.Controls.Add(this.teamTxt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Match";
            this.Text = "Match";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox teamTxt1;
        private System.Windows.Forms.TextBox teamTxt2;
        private System.Windows.Forms.TextBox goalsTxt1;
        private System.Windows.Forms.TextBox goalsTxt2;
        private System.Windows.Forms.TextBox yellowTxt1;
        private System.Windows.Forms.TextBox yellowTxt2;
        private System.Windows.Forms.TextBox redTxt1;
        private System.Windows.Forms.TextBox redTxt2;
        private System.Windows.Forms.Label teamLbl1;
        private System.Windows.Forms.Label teamLbl2;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.Label goalsLbl;
        private System.Windows.Forms.Label yellowLbl;
        private System.Windows.Forms.Label redLbl;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.TextBox statusTxt;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
    }
}