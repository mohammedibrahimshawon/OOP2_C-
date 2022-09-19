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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Admin" && txtpassword.Text == "1234")
            {
                new Coach().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or Password is not correct,Pleaser try again");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();

            }
        }


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (txtusername.Text == "Coach" && txtpassword.Text == "1234")
                {
                    new Coach().Show();
                    this.Hide();
                }
                else if (txtusername.Text == "Admin" && txtpassword.Text == "1234")
                {
                    new Admin().Show();
                    this.Hide();
                }
                else if (txtusername.Text == "Player" && txtpassword.Text == "1234")
                {
                    new player().Show();
                    this.Hide();
                }
                else if (txtusername.Text == "Staff" && txtpassword.Text == "1234")
                {
                    new Staff().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The username or Password is not correct,Pleaser try again");
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtusername.Focus();

                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }
//    }
//}
