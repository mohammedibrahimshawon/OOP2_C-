
namespace SoccerManagementSystem
{
    partial class Staff
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
            this.btnRf = new System.Windows.Forms.Button();
            this.btnWs = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRf
            // 
            this.btnRf.Location = new System.Drawing.Point(531, 396);
            this.btnRf.Margin = new System.Windows.Forms.Padding(4);
            this.btnRf.Name = "btnRf";
            this.btnRf.Size = new System.Drawing.Size(232, 86);
            this.btnRf.TabIndex = 29;
            this.btnRf.Text = "Report Feedback";
            this.btnRf.UseVisualStyleBackColor = true;
            // 
            // btnWs
            // 
            this.btnWs.Location = new System.Drawing.Point(13, 396);
            this.btnWs.Margin = new System.Windows.Forms.Padding(4);
            this.btnWs.Name = "btnWs";
            this.btnWs.Size = new System.Drawing.Size(232, 86);
            this.btnWs.TabIndex = 28;
            this.btnWs.Text = "Work Schedule";
            this.btnWs.UseVisualStyleBackColor = true;
            this.btnWs.Click += new System.EventHandler(this.btnWs_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(763, 99);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 41);
            this.username.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Welcome ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SoccerManagementSystem.Properties.Resources.working_staff_vector_flat_color_icon_working_staff_icon_website_design_desktop_envelopment_development_premium_pack_1673531892;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 495);
            this.Controls.Add(this.btnRf);
            this.Controls.Add(this.btnWs);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRf;
        private System.Windows.Forms.Button btnWs;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}