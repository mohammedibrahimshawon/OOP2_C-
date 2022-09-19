
namespace SoccerManagementSystem
{
    partial class Coach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.buttonPp = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonWi = new System.Windows.Forms.Button();
            this.buttonRt = new System.Windows.Forms.Button();
            this.buttonAi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(32, 34);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(134, 38);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.Location = new System.Drawing.Point(151, 276);
            this.buttonPi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(162, 57);
            this.buttonPi.TabIndex = 1;
            this.buttonPi.Text = "Player Instructions";
            this.buttonPi.UseVisualStyleBackColor = true;
            this.buttonPi.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPp
            // 
            this.buttonPp.Location = new System.Drawing.Point(151, 376);
            this.buttonPp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPp.Name = "buttonPp";
            this.buttonPp.Size = new System.Drawing.Size(162, 62);
            this.buttonPp.TabIndex = 2;
            this.buttonPp.Text = "Player Performance";
            this.buttonPp.UseVisualStyleBackColor = true;
            this.buttonPp.Click += new System.EventHandler(this.buttonPp_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(362, 276);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Player Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonWi
            // 
            this.buttonWi.Location = new System.Drawing.Point(584, 275);
            this.buttonWi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWi.Name = "buttonWi";
            this.buttonWi.Size = new System.Drawing.Size(159, 58);
            this.buttonWi.TabIndex = 4;
            this.buttonWi.Text = "Workout Instruction";
            this.buttonWi.UseVisualStyleBackColor = true;
            this.buttonWi.Click += new System.EventHandler(this.buttonWi_Click);
            // 
            // buttonRt
            // 
            this.buttonRt.Location = new System.Drawing.Point(362, 376);
            this.buttonRt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRt.Name = "buttonRt";
            this.buttonRt.Size = new System.Drawing.Size(164, 62);
            this.buttonRt.TabIndex = 5;
            this.buttonRt.Text = "Reporting TIme";
            this.buttonRt.UseVisualStyleBackColor = true;
            this.buttonRt.Click += new System.EventHandler(this.buttonRt_Click);
            // 
            // buttonAi
            // 
            this.buttonAi.Location = new System.Drawing.Point(584, 376);
            this.buttonAi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAi.Name = "buttonAi";
            this.buttonAi.Size = new System.Drawing.Size(159, 62);
            this.buttonAi.TabIndex = 6;
            this.buttonAi.Text = "Admin Instructions";
            this.buttonAi.UseVisualStyleBackColor = true;
            this.buttonAi.Click += new System.EventHandler(this.buttonAi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome,";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SoccerManagementSystem.Properties.Resources._360_F_100003169_uMg5nB171ogYAB4eYfks8GxNsvZfEYqy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAi);
            this.Controls.Add(this.buttonRt);
            this.Controls.Add(this.buttonWi);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonPp);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonProfile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "Coach";
            this.Text = "Coach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonPi;
        private System.Windows.Forms.Button buttonPp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonWi;
        private System.Windows.Forms.Button buttonRt;
        private System.Windows.Forms.Button buttonAi;
        private System.Windows.Forms.Label label1;
    }
}