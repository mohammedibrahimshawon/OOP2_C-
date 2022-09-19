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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        public string type, name;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (type == "Admin")
            {

                Admin a = new Admin();
                // a.name = this.name;
                a.Show();



                //    a.name = this.name;
                //  A.type = this.type;
                //A.Show();
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
                //pl.name = this.name;
                //pl.type = this.type;
                pl.Show();
                this.Hide();
            }
            else if (type == "Staff")
            {
                 Staff st = new Staff();
            
                st.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.type = this.type;
            ep.name = this.name;
            ep.Show();
            this.Hide();
        }

      
            
        private void Profile_Load(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT [SoccerManagementSystem].[dbo].[Employee].*,[SoccerManagementSystem].[dbo].[UserLogin].type FROM [SoccerManagementSystem].[dbo].[Employee],[SoccerManagementSystem].[dbo].[UserLogin] where [SoccerManagementSystem].[dbo].[UserLogin].userID = '" + name + "' and [SoccerManagementSystem].[dbo].[Employee].userID = '" + name + "'");


            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SoccerManagementSystem"].ConnectionString);
            connection.Open();

            string sql = "INSERT INTO PROFILE(Name,address,phone,gender,type,nid,salary,joindate) VALUES()";

              
            SqlCommand command = new SqlCommand(sql, connection);






            namelb.Text = dt.Rows[0]["name"].ToString();
            addresslb.Text = dt.Rows[0]["address"].ToString();
            emaillb.Text = dt.Rows[0]["userID"].ToString();
            phonelb.Text = dt.Rows[0]["phone"].ToString();
            genderlb.Text = dt.Rows[0]["gender"].ToString();
            typelb.Text = dt.Rows[0]["type"].ToString();
            nidlb.Text = dt.Rows[0]["nid"].ToString();
            salarylb.Text = dt.Rows[0]["salary"].ToString();
            joindatelb.Text = dt.Rows[0]["joindate"].ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            login lg = new login();
             lg.Show();
            this.Hide();
        }
    }
}
