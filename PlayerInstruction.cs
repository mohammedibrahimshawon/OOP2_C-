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
    public partial class PlayerInstruction : Form
    {
        public PlayerInstruction()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public string name, type;
        private void ldbtn_Click(object sender, EventArgs e)
        {
           // DataTable dt = DataAccess.LoadData("SELECT [SoccerManagemnetSystem].[dbo].[Employee].*,[Soccer].[dbo].[UserLogin].type,[Soccer].[dbo].[teamFormat].team  FROM [Soccer].[dbo].[Employee],[Soccer].[dbo].[UserLogin], [Soccer].[dbo].[teamFormat] where [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[Employee].userID AND [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[teamFormat].userID");

            // dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();


            //   DataTable dt2 = DataAccess.LoadData("SELECT [Soccer].[dbo].[PlayerPerformance].*,[Soccer].[dbo].[UserLogin].type FROM [Soccer].[dbo].[UserLogin], [Soccer].[dbo].[PlayerPerformance] where [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[PlayerPerformance].userID");

            /// dataGridView2.DataSource = dt2;
            dataGridView2.Refresh();
            dataGridView2.ClearSelection();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT [Soccer].[dbo].[Employee].*,[Soccer].[dbo].[UserLogin].type FROM [Soccer].[dbo].[Employee],[Soccer].[dbo].[UserLogin] where [Soccer].[dbo].[UserLogin].userID =  [Soccer].[dbo].[Employee].userID AND [Soccer].[dbo].[UserLogin].type = 'player'";

            if (!string.IsNullOrEmpty(searchtxt.Text))
            {
                query += " and Employee.Name like '%" + searchtxt.Text + "%'";
            }
            // DataTable dt = DataAccess.LoadData(query);

            //  dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void PlayerInstruction_Load(object sender, EventArgs e)
        {
            ldbtn.PerformClick();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Coach C = new Coach();
            C.name = this.name;
            C.type = this.type;
            C.Show();
            this.Hide();
        }
    }
}

