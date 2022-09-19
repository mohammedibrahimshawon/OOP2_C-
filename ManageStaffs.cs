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
    public partial class ManageStaffs : Form
    {
        public ManageStaffs()
        {
            InitializeComponent();
        }

        private void ManageStaffs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
