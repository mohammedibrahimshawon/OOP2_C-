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
    public partial class workout_monitor : Form
    {
        public workout_monitor()
        {
            InitializeComponent();
        }

        private void workout_monitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void w_m_home_button_Click(object sender, EventArgs e)
        {
            player player_home = new player();
            player_home.Show();
            this.Hide();
        }
    }
}
