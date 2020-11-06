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
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();
        }

        
        public string Coach
        {
            set
            {
                coachTxt.Text = value;
            }
        }

        public ListView Players
        {
            get
            {
                return playersList;
            }
        }

        private void playersList_MouseClick(object sender, MouseEventArgs e)
        {
            string Goals = "";
            string Yellow = "";
            string Red = "";
            string selectedPlayer = playersList.SelectedItems[0].Text;
            sqlCommand1.CommandText = "select count(goals.player_id) from players left join goals " +
                "on goals.player_id = players.player_id " +
                "where players.player_id in (select player_id from players where fullname = '"+selectedPlayer+"')";
            SqlDataReader dReader1;
            sqlConnection1.Open();
            dReader1 = sqlCommand1.ExecuteReader();
            while (dReader1.Read())
            {
                Goals=dReader1[0].ToString();
            }
            dReader1.Close();
            //**
            sqlCommand1.CommandText = "select count(yellow_cards.player_id) from players left join yellow_cards " +
                "on yellow_cards.player_id = players.player_id " +
                "where players.player_id in (select player_id from players where fullname = '"+selectedPlayer+"') ";
            SqlDataReader dReader2;
            dReader2 = sqlCommand1.ExecuteReader();
            while (dReader2.Read())
            {
                Yellow = dReader2[0].ToString();
            }
            dReader2.Close();
            sqlCommand1.CommandText = "select count(red_cards.player_id) from players left join red_cards " +
            "on red_cards.player_id = players.player_id " +
            "where players.player_id in (select player_id from players where fullname = '" + selectedPlayer + "') ";
            SqlDataReader dReader3;
            dReader3 = sqlCommand1.ExecuteReader();
            while (dReader3.Read())
            {
                Red = dReader3[0].ToString();
            }
            dReader3.Close();
            MessageBox.Show("Player : " + selectedPlayer + "\nGoals : " + Goals + "\nYellow cards : " + Yellow +"\nRed cards : "+Red);
            sqlConnection1.Close();
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
