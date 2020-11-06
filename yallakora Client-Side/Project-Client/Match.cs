using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Client
{
    public partial class Match : Form
    {
        public Match()
        {
            InitializeComponent();
        }
        public string Team1
        {
            set
            {
               teamTxt1.Text = value;
            }
        }

        public string Team2
        {
            set
            {
                teamTxt2.Text = value;
            }
        }

        public string Goals1
        {
            set
            {
                goalsTxt1.Text = value;
            }
        }
        public string Goals2
        {
            set
            {
                goalsTxt2.Text = value;
            }
        }

        public string Status
        {
            set
            {
                statusTxt.Text = value;
            }
        }
        public string Date
        {
            set
            {
                dateTxt.Text = value;
            }
        }
        public string Yellow1
        {
            set
            {
                yellowTxt1.Text = value;
            }
        }
        public string Yellow2
        {
            set
            {
                yellowTxt2.Text = value;
            }
        }

        public string Red1
        {
            set
            {
                redTxt1.Text = value;
            }
        }
        public string Red2
        {
            set
            {
                redTxt2.Text = value;
            }
        }
        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
