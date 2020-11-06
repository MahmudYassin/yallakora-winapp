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
    public partial class Player : Form
    {
        private string index;
        public Player()
        {
            InitializeComponent();
           // fillCombo();
        }
        //void fillCombo()
        //{
        //    sqlCommand1.CommandText = "select * from teams";
        //    SqlDataReader dReader;
        //    sqlConnection1.Open();
        //    dReader = sqlCommand1.ExecuteReader();
        //    comboTeam.Items.Clear();
        //    while (dReader.Read())
        //    {
        //        comboTeam.Items.Add((string)dReader[1]);

        //    }

        //    dReader.Close();
        //    sqlConnection1.Close();
        //}

        private void comboTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboTeam.Text;

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxAge.Text) || String.IsNullOrEmpty(textBoxNum.Text) || String.IsNullOrEmpty(textBoxPlayer.Text))
            {
                MessageBox.Show("Please enter player's full data!");
                return;
            }
            sqlCommand1.CommandText = "select number from players where team_id in (select team_id from teams where name = '" + comboTeam.Text + "')";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            while (dReader.Read())
            {
                if ((int)dReader[0] == int.Parse(textBoxNum.Text))
                {
                    MessageBox.Show("Number is already taken");
                    dReader.Close();
                    sqlConnection1.Close();
                    return;
                }
            }
            dReader.Close();
            sqlConnection1.Close();

            sqlCommand1.CommandText = "insert into players (fullname, team_id, age, number) values('" + textBoxPlayer.Text + "'," +
            " (select team_id from teams where name='" + index + "'), " + textBoxAge.Text + ", " + textBoxNum.Text + ")";
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            textBoxPlayer.Text = "";
            textBoxAge.Text = "";
            textBoxNum.Text = "";
        }

        private void AddPlayerForm_Load(object sender, EventArgs e)
        {
            loadTheme();
            sqlCommand1.CommandText = "select * from leagues";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            comboBox1.Items.Clear();
            while (dReader.Read())
            {
                comboBox1.Items.Add((string)dReader[1]);

            }

            dReader.Close();
            sqlConnection1.Close();
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
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlCommand1.CommandText = "select * from teams where league_id =(select league_id from leagues where name ='"+ comboBox1.Text+"')";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            comboTeam.Items.Clear();
            while (dReader.Read())
            {
                comboTeam.Items.Add((string)dReader[1]);

            }

            dReader.Close();
            sqlConnection1.Close();
        }
    }
}
