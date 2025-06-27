namespace Farm_School
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.userMbtn = new System.Windows.Forms.Button();
            this.courseMbtn = new System.Windows.Forms.Button();
            this.announcebtn = new System.Windows.Forms.Button();
            this.batchMbtn = new System.Windows.Forms.Button();
            this.viewprofilesbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.textlbl2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userMbtn
            // 
            this.userMbtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.userMbtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMbtn.Location = new System.Drawing.Point(25, 142);
            this.userMbtn.Name = "userMbtn";
            this.userMbtn.Size = new System.Drawing.Size(226, 54);
            this.userMbtn.TabIndex = 2;
            this.userMbtn.Text = "User Management";
            this.userMbtn.UseVisualStyleBackColor = false;
            this.userMbtn.Click += new System.EventHandler(this.UserMbtn_Click);
            // 
            // courseMbtn
            // 
            this.courseMbtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.courseMbtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseMbtn.Location = new System.Drawing.Point(25, 284);
            this.courseMbtn.Name = "courseMbtn";
            this.courseMbtn.Size = new System.Drawing.Size(226, 54);
            this.courseMbtn.TabIndex = 3;
            this.courseMbtn.Text = "Course Management";
            this.courseMbtn.UseVisualStyleBackColor = false;
            this.courseMbtn.Click += new System.EventHandler(this.CourseMbtn_Click);
            // 
            // announcebtn
            // 
            this.announcebtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.announcebtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcebtn.Location = new System.Drawing.Point(574, 142);
            this.announcebtn.Name = "announcebtn";
            this.announcebtn.Size = new System.Drawing.Size(226, 54);
            this.announcebtn.TabIndex = 4;
            this.announcebtn.Text = "Announcement";
            this.announcebtn.UseVisualStyleBackColor = false;
            this.announcebtn.Click += new System.EventHandler(this.Announcebtn_Click);
            // 
            // batchMbtn
            // 
            this.batchMbtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.batchMbtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchMbtn.Location = new System.Drawing.Point(574, 284);
            this.batchMbtn.Name = "batchMbtn";
            this.batchMbtn.Size = new System.Drawing.Size(226, 54);
            this.batchMbtn.TabIndex = 5;
            this.batchMbtn.Text = "Batch Management";
            this.batchMbtn.UseVisualStyleBackColor = false;
            this.batchMbtn.Click += new System.EventHandler(this.BatchMbtn_Click);
            // 
            // viewprofilesbtn
            // 
            this.viewprofilesbtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.viewprofilesbtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewprofilesbtn.Location = new System.Drawing.Point(302, 344);
            this.viewprofilesbtn.Name = "viewprofilesbtn";
            this.viewprofilesbtn.Size = new System.Drawing.Size(226, 54);
            this.viewprofilesbtn.TabIndex = 7;
            this.viewprofilesbtn.Text = "View Profiles";
            this.viewprofilesbtn.UseVisualStyleBackColor = false;
            this.viewprofilesbtn.Click += new System.EventHandler(this.viewprofilesbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.Crimson;
            this.logoutbtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Location = new System.Drawing.Point(349, 404);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(128, 43);
            this.logoutbtn.TabIndex = 8;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // textlbl2
            // 
            this.textlbl2.AutoSize = true;
            this.textlbl2.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textlbl2.Location = new System.Drawing.Point(252, 26);
            this.textlbl2.Name = "textlbl2";
            this.textlbl2.Size = new System.Drawing.Size(325, 53);
            this.textlbl2.TabIndex = 9;
            this.textlbl2.Text = "FARM SCHOOL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(828, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textlbl2);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.viewprofilesbtn);
            this.Controls.Add(this.batchMbtn);
            this.Controls.Add(this.announcebtn);
            this.Controls.Add(this.courseMbtn);
            this.Controls.Add(this.userMbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Admin Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button userMbtn;
        private System.Windows.Forms.Button courseMbtn;
        private System.Windows.Forms.Button announcebtn;
        private System.Windows.Forms.Button batchMbtn;
        private System.Windows.Forms.Button viewprofilesbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label textlbl2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}