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

namespace Project_Client
{
    public partial class LeagueInfo : Form
    {
        public LeagueInfo()
        {
            InitializeComponent();
            fillCombo();
        }

        private void selectLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LeagueName = selectLeague.Text;
            sqlCommand1.CommandText = "select teams.name, wins, draws, loss, goals_for, goals_against, points" +
                " from teams inner join leagues on teams.league_id=leagues.league_id" +
                " where leagues.league_id in (select league_id from leagues where name='"+LeagueName+"')" +
                " order by points desc";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            matchList.Items.Clear();
            while (dReader.Read())
            {
                var League = new ListViewItem(new[] { dReader[0].ToString(), dReader[1].ToString(), dReader[2].ToString(), dReader[3].ToString(), dReader[4].ToString(), dReader[5].ToString(), dReader[6].ToString() });
                matchList.Items.Add(League);
            }
            dReader.Close();

            sqlCommand1.CommandText = "select match_id,concat(t1.name,' vs ',t2.name) from matches m  inner join teams t1 "
                                            + "on m.team1_id = t1.team_id inner join teams t2 on m.team2_id = t2.team_id "
                                            + "where t1.league_id = (select league_id from leagues where name ='" + LeagueName + "' ) ";
            SqlDataReader dReader1;
            dReader1 = sqlCommand1.ExecuteReader();
            scheduleList.Items.Clear();
            while (dReader1.Read())
            {

                var Match = new ListViewItem(new[] { dReader1[0].ToString(), dReader1[1].ToString() });
                scheduleList.Items.Add(Match);
            }
            dReader1.Close();
            sqlConnection1.Close();

        }
        private void fillCombo()
        {
            sqlCommand1.CommandText = "select * from leagues";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            selectLeague.Items.Clear();
            while (dReader.Read())
            {
                selectLeague.Items.Add((string)dReader[1]);
            }
            dReader.Close();
            sqlConnection1.Close();
        }

        private void matchList_MouseClick(object sender, MouseEventArgs e)
        {
            Team Team = new Team();
            string selectedTeam = matchList.SelectedItems[0].Text;
            sqlCommand1.CommandText = "select * from players where team_id in (select team_id from teams where name = '"+selectedTeam+"')";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            Team.Players.Items.Clear();
            while (dReader.Read())
            {
                var player = new ListViewItem(new[] {dReader[1].ToString(), dReader[2].ToString(), dReader[3].ToString() });
                Team.Players.Items.Add(player);
            }
            dReader.Close();
            sqlCommand1.CommandText = "select * from teams where name = '" + selectedTeam + "'";
            SqlDataReader dReader1;
            dReader1 = sqlCommand1.ExecuteReader();
            Team.Coach = "";
            while (dReader1.Read())
            {
               Team.Coach=dReader1[2].ToString();
            }
            dReader1.Close();
            sqlConnection1.Close();
            Team.Show();
        }

        private void scheduleList_MouseClick(object sender, MouseEventArgs e)
        {
            Match Match = new Match();
            string selectedMatch = scheduleList.SelectedItems[0].Text;
            sqlCommand1.CommandText = "select t1.name,t2.name , status, date , isnull(team1_score,0),isnull(team2_score,0)" +
                " from matches inner join teams t1" +
                " on t1.team_id = matches.team1_id" +
                " inner join teams t2" +
                " on t2.team_id = matches.team2_id " +
                "where match_id = " +selectedMatch;
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            while (dReader.Read())
            {
                Match.Team1 = dReader[0].ToString();
                Match.Team2 = dReader[1].ToString();
                Match.Status = dReader[2].ToString();
                Match.Date = dReader[3].ToString();
                Match.Goals1 = dReader[4].ToString();
                Match.Goals2 = dReader[5].ToString();
            }
            dReader.Close();

            sqlCommand1.CommandText = "select count(y1.team_id) from yellow_cards y1 where y1.match_id = " + selectedMatch 
                + " and team_id = (select team1_id from matches where match_id = "+ selectedMatch +")";
            SqlDataReader dReader1;
            dReader1 = sqlCommand1.ExecuteReader();
            while (dReader1.Read())
            {
                Match.Yellow1 = dReader1[0].ToString();
            }
            dReader1.Close();

            sqlCommand1.CommandText = "select count(y1.team_id) from yellow_cards y1 where y1.match_id = " + selectedMatch
                + " and team_id = (select team2_id from matches where match_id = " + selectedMatch + ")";
            SqlDataReader dReader2;
            dReader2 = sqlCommand1.ExecuteReader();
            while (dReader2.Read())
            {
                Match.Yellow2 = dReader2[0].ToString();
            }
            dReader2.Close();

            sqlCommand1.CommandText = "select count(r1.team_id) from red_cards r1 where r1.match_id = " + selectedMatch
                + " and team_id = (select team1_id from matches where match_id = " + selectedMatch + ")";
            SqlDataReader dReader3;
            dReader3 = sqlCommand1.ExecuteReader();
            while (dReader3.Read())
            {
                Match.Red1 = dReader3[0].ToString();
            }
            dReader3.Close();

            sqlCommand1.CommandText = "select count(r1.team_id) from red_cards r1 where r1.match_id = " + selectedMatch
                + " and team_id = (select team2_id from matches where match_id = " + selectedMatch + ")";
            SqlDataReader dReader4;
            dReader4 = sqlCommand1.ExecuteReader();
            while (dReader4.Read())
            {
                Match.Red2 = dReader4[0].ToString();
            }
            dReader4.Close();

            sqlConnection1.Close();
            Match.Show();
        }
    }
}
