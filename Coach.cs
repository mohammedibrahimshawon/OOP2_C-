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
    public partial class Coach : Form
    {
        public Coach()
        {
            InitializeComponent();
        }
        public string name, type;
        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void button2_Click(object sender, EventArgs e)
        {
            PlayerInstruction pi = new PlayerInstruction();
            pi.Name = this.name;
             pi.type = this.type;
            pi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayerDetails pd = new PlayerDetails();
            pd.name = this.name;
            pd.type = this.type;
            pd.Show();
            this.Hide();
        }

        private void buttonWi_Click(object sender, EventArgs e)
        {
            WorkoutInstruction wi = new WorkoutInstruction();
            wi.name = this.name;
            wi.type = this.type;
            wi.Show();
            this.Hide();
        }

        private void buttonPp_Click(object sender, EventArgs e)
        {
            PlayerPerformance pf = new PlayerPerformance();
             // pf.name = this.name;
             // pf.type = this.type;
            pf.Show();
            this.Hide();
        }

        private void buttonRt_Click(object sender, EventArgs e)
        {
            ReportingTime rt = new ReportingTime();
            rt.name = this.name;
            rt.type = this.type;
            rt.Show();
            this.Hide();
        }

        private void buttonAi_Click(object sender, EventArgs e)
        {
            AdminInstructions ai = new AdminInstructions();
            ai.name = this.name;
           ai.type = this.type;
            ai.Show();
            this.Hide();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Profile pr = new Profile();
            pr.type = this.type;
            pr.name = this.name;
            pr.Show();
            this.Hide();
        }

        //private void Coach_FormClosing(object sender, FormClosingEventArgs e)
        //{


        //    Application.Exit();
        //}

        //protected override void Form1_FormClosing(object sender, FormclosingEventArgs e)
        //{
        //    base.Form1_FormClosing(e);
        //    Application.Exit();
        //}
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}
    

