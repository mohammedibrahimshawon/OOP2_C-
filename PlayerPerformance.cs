using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerManagementSystem
{
    public partial class PlayerPerformance : Form
    {
        public PlayerPerformance()
        {
            InitializeComponent();
        }

        private void p_m_home_button_Click(object sender, EventArgs e)
        {
            {
                player player_Home = new player();
                player_Home.Show();
                this.Hide();
            } 
        }

        private void PlayerPerformance_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
