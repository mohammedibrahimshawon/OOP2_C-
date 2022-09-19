using SoccerManagementSystem.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerManagementSystem
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }
        public string type, name;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (type == "Admin")
            {
                Admin A = new Admin();
               // A.name = this.name;
                //A.type = this.type;
                A.Show();
                this.Hide();

            }

            else if (type == "Coach")
            {
                Coach c = new Coach();
                c.name = this.name;
                c.type = this.type;
                c.Show();
                this.Hide();
            }

            else if (type == "Player")
            {
               player pl = new player();
               // pl.name = this.name;
                //pl.type = this.type;
                pl.Show();
                this.Hide();
            }
            else if (type == "Staff")
            {
                //Staff st = new Staff();
                //st.name = this.name;
                //st.type = this.type;
                //st.Show();
                //this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nametxt.Text != "" && addresstxt.Text != "" && phonetxt.Text != "" && gendertxt.SelectedItem.ToString() != "" && nidtxt.Text != "")
            {
                string query = "";

                query = "  update [SoccerManagementSystem].[dbo].[Employee] set name='" + nametxt.Text + "',address='" + addresstxt.Text + "',phone='" + phonetxt.Text + "',gender='" + gendertxt.SelectedItem + "',nid='" + nidtxt.Text + "' where [SoccerManagementSystem].[dbo].[Employee].userID = '" + name + "'";


                int row = DataAccess.ExecuteQuery(query);
                if (row > 0)
                {
                    MessageBox.Show("Operation Completed");
                    login lg = new login();
                    lg.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("left something blank");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ChangePass cp = new ChangePass();
            //cp.name = this.name;
            //cp.type = this.type;
            //cp.Show();
            //this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            if (type == "Coach")
            {
                typetxt.Enabled = false;
            }
            else if (type == "Player")
            {
                typetxt.Enabled = false;

            }

            DataTable dt = DataAccess.LoadData("SELECT [SoccerManagementSystem].[dbo].[Employee].*,[SoccerManagementSystem].[dbo].[UserLogin].type FROM [SoccerManagementSystem].[dbo].[Employee],[SoccerManagementSystem].[dbo].[UserLogin] where [SoccerManagementSystem].[dbo].[UserLogin].userID = '" + name + "' and [SoccerManagementSystem].[dbo].[Employee].userID = '" + name + "'");

            //DataTable dt = DataAccess.LoadData("SELECT [SoccerManagementSystem].[dbo].[Employee].*,[SoccerManagementSystem].[dbo].[UserLogin].type FROM [SoccerManagementSystem].[dbo].[Employee],[SoccerManagementSystem].[dbo].[UserLogin] where [SoccerManagementSystem].[dbo].[UserLogin].userID = '" + name + "' and [SoccerManagementSystem].[dbo].[Employee].userID = '" + name + "'");


            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SoccerManagementSystem"].ConnectionString);
            connection.Open();

            string sql = "INSERT INTO PROFILE(Name,address,phone,gender,type,nid,salary,joindate) VALUES()";


            SqlCommand command = new SqlCommand(sql, connection);

            nametxt.Text = dt.Rows[0]["name"].ToString();
            addresstxt.Text = dt.Rows[0]["address"].ToString();
          //  .Text = dt.Rows[0]["userID"].ToString();
            phonetxt.Text = dt.Rows[0]["phone"].ToString();
            gendertxt.Text = dt.Rows[0]["gender"].ToString();
            typetxt.Text = dt.Rows[0]["type"].ToString();
            nidtxt.Text = dt.Rows[0]["nid"].ToString();

        }
    }
}
