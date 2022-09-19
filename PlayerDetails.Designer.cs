
namespace SoccerManagementSystem
{
    partial class PlayerDetails
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "PlayerDetails";


            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.ldbtn = new System.Windows.Forms.Button();
            this.dlbtn = new System.Windows.Forms.Button();
            this.userid = new System.Windows.Forms.TextBox();
            this.useridlbl = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(846, 459);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(538, 54);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(159, 52);
            this.searchbtn.TabIndex = 84;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click_1);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(200, 67);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(330, 26);
            this.searchtxt.TabIndex = 83;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // ldbtn
            // 
            this.ldbtn.Location = new System.Drawing.Point(13, 54);
            this.ldbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ldbtn.Name = "ldbtn";
            this.ldbtn.Size = new System.Drawing.Size(159, 52);
            this.ldbtn.TabIndex = 85;
            this.ldbtn.Text = "Load";
            this.ldbtn.UseVisualStyleBackColor = true;
            this.ldbtn.Click += new System.EventHandler(this.ldbtn_Click_1);
            // 
            // dlbtn
            // 
            this.dlbtn.Location = new System.Drawing.Point(769, 44);
            this.dlbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dlbtn.Name = "dlbtn";
            this.dlbtn.Size = new System.Drawing.Size(178, 72);
            this.dlbtn.TabIndex = 86;
            this.dlbtn.Text = "Delete";
            this.dlbtn.UseVisualStyleBackColor = true;
            this.dlbtn.Click += new System.EventHandler(this.dlbtn_Click_1);
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(1003, 242);
            this.userid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Size = new System.Drawing.Size(224, 26);
            this.userid.TabIndex = 90;
            this.userid.TextChanged += new System.EventHandler(this.userid_TextChanged);
            // 
            // useridlbl
            // 
            this.useridlbl.AutoSize = true;
            this.useridlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridlbl.Location = new System.Drawing.Point(905, 242);
            this.useridlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.useridlbl.Name = "useridlbl";
            this.useridlbl.Size = new System.Drawing.Size(99, 29);
            this.useridlbl.TabIndex = 89;
            this.useridlbl.Text = "User ID:";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(941, 188);
            this.idtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(224, 26);
            this.idtxt.TabIndex = 88;
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(905, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 87;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(978, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 91;
            this.label2.Text = "Team Assign";
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Terminated"});
            this.cmbTeam.Location = new System.Drawing.Point(902, 340);
            this.cmbTeam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(349, 28);
            this.cmbTeam.TabIndex = 92;
            this.cmbTeam.SelectedIndexChanged += new System.EventHandler(this.cmbTeam_SelectedIndexChanged);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(2038, 675);
            this.editbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(159, 52);
            this.editbtn.TabIndex = 93;
            this.editbtn.Text = "Update";
            this.editbtn.UseVisualStyleBackColor = true;
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(1003, 44);
            this.homebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(198, 72);
            this.homebtn.TabIndex = 94;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click_1);
            // 
            // PlayerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 611);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.cmbTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.useridlbl);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dlbtn);
            this.Controls.Add(this.ldbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlayerDetails";
            this.Text = "Player Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button ldbtn;
        private System.Windows.Forms.Button dlbtn;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.Label useridlbl;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button homebtn;
    }
}

       