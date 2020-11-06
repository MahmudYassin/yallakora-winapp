using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yallakora_App
{
    public partial class Match : Form
    {
        private string leagueIndex;
        private string team1Index;
        private string team2Index;
        private string statusIndex;
        public Match()
        {
            InitializeComponent();
            fillLeagueCombo();
            fillStatusCombo();
        }

        private void comboLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            leagueIndex = comboLeague.Text;

            sqlCommand1.CommandText = "select * from teams where league_id = (select league_id from leagues where name ='" + leagueIndex + "' ) ";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            comboTeam1.Items.Clear();
            while (dReader.Read())
            {
                comboTeam1.Items.Add((string)dReader[1]);

            }
            dReader.Close();
            sqlConnection1.Close();
        }

        private void comboTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            team1Index = comboTeam1.Text;

            sqlCommand1.CommandText = "select * from teams where league_id = (select league_id from leagues where name ='" + leagueIndex + "' ) and name != '" + team1Index + "'";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            comboTeam2.Items.Clear();
            while (dReader.Read())
            {
                comboTeam2.Items.Add((string)dReader[1]);

            }
            dReader.Close();
            sqlConnection1.Close();
        }

        private void comboTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            team2Index = comboTeam2.Text;
        }

        void fillLeagueCombo()
        {
            sqlCommand1.CommandText = "select * from leagues";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            comboLeague.Items.Clear();
            while (dReader.Read())
            {
                comboLeague.Items.Add((string)dReader[1]);

            }
            dReader.Close();
            sqlConnection1.Close();
        }

        void fillStatusCombo()
        {
            comboStatus.Items.Add("not started");
            comboStatus.Items.Add("started");
            comboStatus.Items.Add("finished");
            comboStatus.Items.Add("postponed");
        }



        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusIndex = comboStatus.Text;
        }

        private void btnAddMatch_Click_1(object sender, EventArgs e)
        { 
            sqlCommand1.CommandText = "INSERT INTO matches (team1_id,team2_id, team1_score, team2_score, status, date)" +
            " VALUES((select team_id from teams where name='" + team1Index + "') ," +
            "(select team_id from teams where name='" + team2Index + "'), 0, 0,'" + statusIndex + "','" + MatchDate.Text + "')";
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        private void AddMatchForm_Load(object sender, EventArgs e)
        {
            loadTheme();
        }
        private void loadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;

                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
    }
}
