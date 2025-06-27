namespace Farm_School
{
    partial class UserManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            this.show1btn = new System.Windows.Forms.Button();
            this.Updatebtn1 = new System.Windows.Forms.Button();
            this.Deletebtn1 = new System.Windows.Forms.Button();
            this.datagvUser = new System.Windows.Forms.DataGridView();
            this.backbtn1 = new System.Windows.Forms.Button();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Rolecmb = new System.Windows.Forms.ComboBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Rolelbl = new System.Windows.Forms.Label();
            this.textlbl2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // show1btn
            // 
            this.show1btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.show1btn.Location = new System.Drawing.Point(59, 368);
            this.show1btn.Name = "show1btn";
            this.show1btn.Size = new System.Drawing.Size(80, 33);
            this.show1btn.TabIndex = 0;
            this.show1btn.Text = "Show";
            this.show1btn.UseVisualStyleBackColor = false;
            this.show1btn.Click += new System.EventHandler(this.Show1btn_Click);
            // 
            // Updatebtn1
            // 
            this.Updatebtn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Updatebtn1.Location = new System.Drawing.Point(59, 232);
            this.Updatebtn1.Name = "Updatebtn1";
            this.Updatebtn1.Size = new System.Drawing.Size(80, 33);
            this.Updatebtn1.TabIndex = 1;
            this.Updatebtn1.Text = "Update";
            this.Updatebtn1.UseVisualStyleBackColor = false;
            this.Updatebtn1.Click += new System.EventHandler(this.Updatebtn1_Click);
            // 
            // Deletebtn1
            // 
            this.Deletebtn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Deletebtn1.Location = new System.Drawing.Point(59, 303);
            this.Deletebtn1.Name = "Deletebtn1";
            this.Deletebtn1.Size = new System.Drawing.Size(80, 33);
            this.Deletebtn1.TabIndex = 2;
            this.Deletebtn1.Text = "Delete";
            this.Deletebtn1.UseVisualStyleBackColor = false;
            this.Deletebtn1.Click += new System.EventHandler(this.Deletebtn1_Click);
            // 
            // datagvUser
            // 
            this.datagvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvUser.Location = new System.Drawing.Point(209, 162);
            this.datagvUser.Name = "datagvUser";
            this.datagvUser.Size = new System.Drawing.Size(568, 239);
            this.datagvUser.TabIndex = 3;
            // 
            // backbtn1
            // 
            this.backbtn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backbtn1.Location = new System.Drawing.Point(700, 410);
            this.backbtn1.Name = "backbtn1";
            this.backbtn1.Size = new System.Drawing.Size(77, 33);
            this.backbtn1.TabIndex = 4;
            this.backbtn1.Text = "Back";
            this.backbtn1.UseVisualStyleBackColor = false;
            this.backbtn1.Click += new System.EventHandler(this.Backbtn1_Click);
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(209, 119);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(121, 20);
            this.Nametxt.TabIndex = 5;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(454, 119);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(121, 20);
            this.Emailtxt.TabIndex = 7;
            // 
            // Rolecmb
            // 
            this.Rolecmb.FormattingEnabled = true;
            this.Rolecmb.Items.AddRange(new object[] {
            "Farmer",
            "Instructor"});
            this.Rolecmb.Location = new System.Drawing.Point(656, 119);
            this.Rolecmb.Name = "Rolecmb";
            this.Rolecmb.Size = new System.Drawing.Size(121, 21);
            this.Rolecmb.TabIndex = 8;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Addbtn.Location = new System.Drawing.Point(59, 162);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(80, 33);
            this.Addbtn.TabIndex = 9;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(206, 86);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(38, 15);
            this.Namelbl.TabIndex = 10;
            this.Namelbl.Text = "Name";
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(451, 86);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(38, 15);
            this.Emaillbl.TabIndex = 11;
            this.Emaillbl.Text = "Email";
            // 
            // Rolelbl
            // 
            this.Rolelbl.AutoSize = true;
            this.Rolelbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rolelbl.Location = new System.Drawing.Point(653, 86);
            this.Rolelbl.Name = "Rolelbl";
            this.Rolelbl.Size = new System.Drawing.Size(32, 15);
            this.Rolelbl.TabIndex = 12;
            this.Rolelbl.Text = "Role";
            // 
            // textlbl2
            // 
            this.textlbl2.AutoSize = true;
            this.textlbl2.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textlbl2.Location = new System.Drawing.Point(259, 9);
            this.textlbl2.Name = "textlbl2";
            this.textlbl2.Size = new System.Drawing.Size(325, 53);
            this.textlbl2.TabIndex = 13;
            this.textlbl2.Text = "FARM SCHOOL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(824, 455);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backbtn1);
            this.Controls.Add(this.show1btn);
            this.Controls.Add(this.Deletebtn1);
            this.Controls.Add(this.Updatebtn1);
            this.Controls.Add(this.Rolecmb);
            this.Controls.Add(this.Rolelbl);
            this.Controls.Add(this.textlbl2);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.datagvUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManagementForm";
            this.Text = "User Management";
            ((System.ComponentModel.ISupportInitialize)(this.datagvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show1btn;
        private System.Windows.Forms.Button Updatebtn1;
        private System.Windows.Forms.Button Deletebtn1;
        private System.Windows.Forms.DataGridView datagvUser;
        private System.Windows.Forms.Button backbtn1;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.ComboBox Rolecmb;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label Rolelbl;
        private System.Windows.Forms.Label textlbl2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}