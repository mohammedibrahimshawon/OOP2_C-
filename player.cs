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
    public partial class player : Form
    {
        public player()
        {
            InitializeComponent();
        }

        private void player_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            workout_monitor workout_monitor = new workout_monitor();
            workout_monitor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayerPerformance playerPerformance = new PlayerPerformance ();
            playerPerformance.Show();
            this.Hide();
        }

        private void p_h__button_calculate_Click(object sender, EventArgs e)
        {
            double height = double.Parse(heighttextbox.Text);
            double weight = double.Parse(weighttextbox.Text);
            double bmi = 0;
            bmi = weight / (height * height);
            bmiresult.Text = bmi.ToString();
            if (bmi < 18.5)
            {
                MessageBox.Show("You are Underweight!");
            }
            else if (bmi > 24.9)
            {
                MessageBox.Show("You are overweight!");
            }
            else
            {
                MessageBox.Show("You weight is normal!");
            }

        }

        private void inchtextbox_TextChanged(object sender, EventArgs e)
        {
            double inch = double.Parse(inchtextbox.Text);
            double metre = 0;
            metre = inch / 39.37;
            metretextbox.Text = metre.ToString();
        }
    }
}
