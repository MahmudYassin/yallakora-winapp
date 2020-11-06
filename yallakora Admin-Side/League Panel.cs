using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yallakora_App
{
    public partial class League : Form
    {
        public League()
        {
            InitializeComponent();
        }

        private void AddLeagueForm_Load(object sender, EventArgs e)
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

        private void btnLeague_Click(object sender, EventArgs e)
        {
            sqlCommand1.CommandText = "INSERT INTO leagues (name) VALUES('" + textBoxLeague.Text + "')";
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            textBoxLeague.Text = "";
        }


    }
}
