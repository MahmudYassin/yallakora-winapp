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
    public partial class Info : Form
    {
        private string matchIndex;
        private string leagueIndex;
        public int matchId;
        private int team1_Id;
        private int team2_Id;
        private int selected_playerId;
        private int teamScored;
        public Info()
        {
            InitializeComponent();
            fillLeagueCombo();
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


        public class ComboKeys
        {
            public string name { get; set; }
            public int value { get; set; }
        }

        private List<ComboKeys> teams = new List<ComboKeys>();
        private List<ComboKeys> team1Players = new List<ComboKeys>();
        private List<ComboKeys> team2Players = new List<ComboKeys>();


        private void comboLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            leagueIndex = comboLeague.Text;
            sqlCommand1.CommandText = "select concat(t1.name,' vs ',t2.name), match_id, status from matches m  inner join teams t1 "
                                + "on m.team1_id = t1.team_id inner join teams t2 on m.team2_id = t2.team_id "
                                + "where t1.league_id = (select league_id from leagues where name ='" + leagueIndex + "' ) ";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            comboMatch.Items.Clear();
            while (dReader.Read())
            {
                if ((string)dReader[2] == "finished")
                {
                    continue;
                }
                    teams.Add(new ComboKeys() { name = (string)dReader[0], value = (int)dReader[1] });
                    comboMatch.Items.Add(dReader[0]);
            }

            dReader.Close();
            sqlConnection1.Close();
        }

        private void comboMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*matchIndex = comboMatch.Text;
            int firstSpace = matchIndex.IndexOf(" ");
            matchId = matchIndex.Substring(0, firstSpace);*/

            string str = comboMatch.Text;
            ComboKeys found = teams.Find(x => x.name.Contains(str));
            matchId = found.value;

            team1Counter = 0;
            team2Counter = 0;

            sqlCommand1.CommandText = "select team1_id, team2_id from matches inner join teams on team1_id = team_id where match_id =" + matchId;
            SqlDataReader dReaderGetTeamID;
            sqlConnection1.Open();
            dReaderGetTeamID = sqlCommand1.ExecuteReader();
            if (dReaderGetTeamID.Read())
            {
                team1_Id = (int)dReaderGetTeamID[0];
                team2_Id = (int)dReaderGetTeamID[1];

            }
            dReaderGetTeamID.Close();

            sqlCommand1.CommandText = "select name from matches inner join teams on team1_id = team_id where match_id =" + matchId;
            SqlDataReader dReader;
            // sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            while (dReader.Read())
            {
                tbTeam1.Text = (string)dReader[0];
            }
            dReader.Close();


            sqlCommand1.CommandText = "select name from matches inner join teams on team2_id = team_id where match_id =" + matchId;
            SqlDataReader dReader1;
            dReader1 = sqlCommand1.ExecuteReader();
            while (dReader1.Read())
            {
                tbTeam2.Text = (string)dReader1[0];
            }
            dReader1.Close();


            sqlCommand1.CommandText = "select fullname,player_id from players p where p.team_id =(select team_id from teams where name ='" + tbTeam1.Text + "' )";
            SqlDataReader dReader2;
            dReader2 = sqlCommand1.ExecuteReader();
            comboTeam1.Items.Clear();
            while (dReader2.Read())
            {
                team1Players.Add(new ComboKeys() { name = (string)dReader2[0], value = (int)dReader2[1] });
                comboTeam1.Items.Add(dReader2[0]);
            }

            dReader2.Close();

            sqlCommand1.CommandText = "select fullname,player_id from players p where p.team_id =(select team_id from teams where name ='" + tbTeam2.Text + "' )";
            SqlDataReader dReader3;
            dReader3 = sqlCommand1.ExecuteReader();
            comboTeam2.Items.Clear();
            while (dReader3.Read())
            {
                team2Players.Add(new ComboKeys() { name = (string)dReader3[0], value = (int)dReader3[1] });
                comboTeam2.Items.Add(dReader3[0]);
            }

            dReader3.Close();
            sqlConnection1.Close();

        }

        private void comboTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int firstSpace = matchIndex.IndexOf(" ");
            selected_playerId = int.Parse(comboTeam1.Text.Substring(0, firstSpace));*/

            string str = comboTeam1.Text;
            ComboKeys found = team1Players.Find(x => x.name.Contains(str));
            selected_playerId = found.value;
            teamScored = 1;

        }
        private void comboTeam1_Click(object sender, EventArgs e)
        {
            comboTeam2.SelectedIndex = -1;
        }

        private void comboTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int firstSpace = matchIndex.IndexOf(" ");
            selected_playerId = int.Parse(comboTeam2.Text.Substring(0, firstSpace));*/

            string str = comboTeam2.Text;
            ComboKeys found = team2Players.Find(x => x.name.Contains(str));
            selected_playerId = found.value;
            teamScored = 2;
        }
        private void comboTeam2_Click(object sender, EventArgs e)
        {
            comboTeam1.SelectedIndex = -1;
        }


        private int team1Counter;
        private int team2Counter;
        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(tbTeam1Score.Text) || String.IsNullOrEmpty(tbTeam2Score.Text))
            {
                MessageBox.Show("Enter match score!");
                return;
            }
            sqlConnection1.Open();

            int team1score = int.Parse(tbTeam1Score.Text);
            int team2score = int.Parse(tbTeam2Score.Text);
            /*MessageBox.Show(team1Counter.ToString());
            MessageBox.Show((int.Parse(tbGoals.Text) + team1Counter).ToString());*/
            if (teamScored == 1)
            {
                if (!String.IsNullOrEmpty(tbGoals.Text))
                {
                    if ((int.Parse(tbGoals.Text) + team1Counter) > team1score)
                    {
                        MessageBox.Show("Entered goals are more than match score");
                        MessageBox.Show(team1Counter.ToString(), team1score.ToString());
                        sqlConnection1.Close();
                        return;
                    }
                    for (int i = 0; i < int.Parse(tbGoals.Text); i++)
                    {

                        if (team1Counter == team1score)
                        {
                            MessageBox.Show("All goals are accounted for");
                            sqlConnection1.Close();
                            return;
                        }

                        sqlCommand1.CommandText = "insert into goals (match_id, player_id, team_id, team_scored_against_id) values(' " + matchId + " ', '"
                            + selected_playerId + "', '" + team1_Id + "', '" + team2_Id + "')";
                        sqlCommand1.ExecuteNonQuery();
                        team1Counter++;
                    }
                }
                if (!String.IsNullOrEmpty(tbYellowCards.Text))
                {
                    if (int.Parse(tbYellowCards.Text) > 2)
                    {
                        MessageBox.Show("Yellow cards can't be more than 2");
                        sqlConnection1.Close();
                        return;
                    }
                    for (int i = 0; i < int.Parse(tbYellowCards.Text); i++)
                    {
                        sqlCommand1.CommandText = "insert into yellow_cards (match_id, player_id, team_id) values(' " + matchId + " ', '"
                            + selected_playerId + "', '" + team1_Id + "')";
                        sqlCommand1.ExecuteNonQuery();
                    }
                }
                if (!String.IsNullOrEmpty(tbRedCards.Text))
                {
                    if (int.Parse(tbRedCards.Text) > 1)
                    {
                        MessageBox.Show("Red cards can't be more than 1");
                        sqlConnection1.Close();
                        return;
                    }
                    for (int i = 0; i < int.Parse(tbRedCards.Text); i++)
                    {
                        sqlCommand1.CommandText = "insert into red_cards (match_id, player_id, team_id) values(' " + matchId + " ', '"
                            + selected_playerId + "', '" + team1_Id + "')";
                        sqlCommand1.ExecuteNonQuery();
                    }
                }
            }
            else if (teamScored == 2)
            {
                if (!String.IsNullOrEmpty(tbGoals.Text))
                {
                    if ((int.Parse(tbGoals.Text) + team2Counter) > team2score)
                    {
                        MessageBox.Show("Entered goals are more than match score");
                        sqlConnection1.Close();
                        return;
                    }
                    for (int i = 0; i < int.Parse(tbGoals.Text); i++)
                    {
                        if (team2Counter == team2score)
                        {
                            MessageBox.Show("All goals are accounted for");
                            sqlConnection1.Close();
                            return;
                        }
                        sqlCommand1.CommandText = "insert into goals (match_id, player_id, team_id, team_scored_against_id) values(' " + matchId + " ', '"
                        + selected_playerId + "', '" + team2_Id + "', '" + team1_Id + "')";
                        sqlCommand1.ExecuteNonQuery();
                        team2Counter++;
                    }
                }
                if (!String.IsNullOrEmpty(tbYellowCards.Text))
                {
                    if (int.Parse(tbYellowCards.Text) > 2)
                    {
                        MessageBox.Show("Yellow cards can't be more than 2");
                        sqlConnection1.Close();
                        return;
                    }
                    for (int i = 0; i < int.Parse(tbYellowCards.Text); i++)
                        {
                            sqlCommand1.CommandText = "insert into yellow_cards (match_id, player_id, team_id) values(' " + matchId + " ', '"
                                + selected_playerId + "', '" + team2_Id + "')";
                            sqlCommand1.ExecuteNonQuery();
                        }
                    
                }
                if (!String.IsNullOrEmpty(tbRedCards.Text))
                {
                    if (int.Parse(tbRedCards.Text) > 1)
                    {
                        MessageBox.Show("Red cards can't be more than 1");
                        sqlConnection1.Close();
                        return;
                    }
                    for (int i = 0; i < int.Parse(tbRedCards.Text); i++)
                    {
                        sqlCommand1.CommandText = "insert into red_cards (match_id, player_id, team_id) values(' " + matchId + " ', '"
                            + selected_playerId + "', '" + team2_Id + "')";
                        sqlCommand1.ExecuteNonQuery();
                    }
                }
            }
            sqlConnection1.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(tbTeam1Score.Text) || String.IsNullOrEmpty(tbTeam2Score.Text))
            {
                MessageBox.Show("Please enter match score!");
                return;
            }
            if(team1Counter != int.Parse(tbTeam1Score.Text))
            {
                MessageBox.Show("All home team goals are not registered for players");
                return;
            }
            if(team2Counter != int.Parse(tbTeam2Score.Text))
            {
                MessageBox.Show("All away team goals are not registered for players");
                return;
            }

            sqlConnection1.Open();
            sqlCommand1.CommandText = "update matches set team1_score = " + tbTeam1Score.Text
            + ", team2_score = " + tbTeam2Score.Text + ", status = 'finished' where match_id=" + matchId;
            sqlCommand1.ExecuteNonQuery();

            /*MessageBox.Show(tbTeam1Score.Text, tbTeam2Score.Text);*/

            if (int.Parse(tbTeam1Score.Text) > int.Parse(tbTeam2Score.Text))
            {
                sqlCommand1.CommandText = "update teams set points +=3, wins +=1, goals_for += " + tbTeam1Score.Text + "," +
                    " goals_against += " + tbTeam2Score.Text + " where team_id =" + team1_Id;
                sqlCommand1.ExecuteNonQuery();
                sqlCommand1.CommandText = "update teams set loss +=1, goals_for += " + tbTeam2Score.Text + "," +
                    " goals_against += " + tbTeam1Score.Text + " where team_id =" + team2_Id;
                sqlCommand1.ExecuteNonQuery();
            }
            else if (int.Parse(tbTeam1Score.Text) < int.Parse(tbTeam2Score.Text))
            {
                sqlCommand1.CommandText = "update teams set points +=3, wins +=1, goals_for += " + tbTeam2Score.Text + "," +
                    " goals_against += " + tbTeam1Score.Text + " where team_id =" + team2_Id;
                sqlCommand1.ExecuteNonQuery();
                sqlCommand1.CommandText = "update teams set loss +=1, goals_for += " + tbTeam1Score.Text + "," +
                    " goals_against += " + tbTeam2Score.Text + " where team_id =" + team1_Id;
                sqlCommand1.ExecuteNonQuery();
            }
            else if (int.Parse(tbTeam1Score.Text) == int.Parse(tbTeam2Score.Text))
            {
                sqlCommand1.CommandText = "update teams set points +=1, draws +=1, goals_for += " + tbTeam2Score.Text + "," +
                    " goals_against += " + tbTeam1Score.Text + " where team_id =" + team2_Id;
                sqlCommand1.ExecuteNonQuery();
                sqlCommand1.CommandText = "update teams set points +=1, draws +=1, goals_for += " + tbTeam1Score.Text + "," +
                    " goals_against += " + tbTeam2Score.Text + " where team_id =" + team1_Id;
                sqlCommand1.ExecuteNonQuery();
            }
            sqlConnection1.Close();
            comboLeague.SelectedIndex = -1;
            comboMatch.SelectedIndex = -1;
            comboTeam1.SelectedIndex = -1;
            comboTeam2.SelectedIndex = -1;
            tbGoals.Text = "";
            tbTeam1.Text = "";
            tbTeam2.Text = "";
            tbTeam1Score.Text = "";
            tbTeam2Score.Text = "";
        }

        private void AddInfoForm_Load(object sender, EventArgs e)
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
