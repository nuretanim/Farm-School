namespace Farm_School
{
    partial class BatchManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchManagementForm));
            this.Batchnametxt = new System.Windows.Forms.TextBox();
            this.InstructorBatchtxt = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.Coursetitlecmb = new System.Windows.Forms.ComboBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Showbtn = new System.Windows.Forms.Button();
            this.backbtn4 = new System.Windows.Forms.Button();
            this.batchnamelbl = new System.Windows.Forms.Label();
            this.instructorforbatchlbl = new System.Windows.Forms.Label();
            this.SelectClbl = new System.Windows.Forms.Label();
            this.Sdatelbl = new System.Windows.Forms.Label();
            this.Edatelbl = new System.Windows.Forms.Label();
            this.datagvBatch = new System.Windows.Forms.DataGridView();
            this.textlbl2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Batchnametxt
            // 
            this.Batchnametxt.Location = new System.Drawing.Point(683, 94);
            this.Batchnametxt.Name = "Batchnametxt";
            this.Batchnametxt.Size = new System.Drawing.Size(121, 20);
            this.Batchnametxt.TabIndex = 0;
            // 
            // InstructorBatchtxt
            // 
            this.InstructorBatchtxt.Location = new System.Drawing.Point(683, 164);
            this.InstructorBatchtxt.Name = "InstructorBatchtxt";
            this.InstructorBatchtxt.Size = new System.Drawing.Size(121, 20);
            this.InstructorBatchtxt.TabIndex = 1;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(683, 301);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(121, 20);
            this.startDate.TabIndex = 2;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(683, 374);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(121, 20);
            this.endDate.TabIndex = 3;
            // 
            // Coursetitlecmb
            // 
            this.Coursetitlecmb.FormattingEnabled = true;
            this.Coursetitlecmb.Location = new System.Drawing.Point(683, 227);
            this.Coursetitlecmb.Name = "Coursetitlecmb";
            this.Coursetitlecmb.Size = new System.Drawing.Size(121, 21);
            this.Coursetitlecmb.TabIndex = 4;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(134, 417);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(80, 33);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.AccessibleDescription = "";
            this.Updatebtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(276, 416);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(80, 33);
            this.Updatebtn.TabIndex = 8;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(415, 417);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(80, 33);
            this.Deletebtn.TabIndex = 9;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Showbtn
            // 
            this.Showbtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Showbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showbtn.Location = new System.Drawing.Point(553, 417);
            this.Showbtn.Name = "Showbtn";
            this.Showbtn.Size = new System.Drawing.Size(80, 33);
            this.Showbtn.TabIndex = 10;
            this.Showbtn.Text = "Show";
            this.Showbtn.UseVisualStyleBackColor = false;
            this.Showbtn.Click += new System.EventHandler(this.Showbtn_Click);
            // 
            // backbtn4
            // 
            this.backbtn4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.backbtn4.Location = new System.Drawing.Point(727, 417);
            this.backbtn4.Name = "backbtn4";
            this.backbtn4.Size = new System.Drawing.Size(77, 30);
            this.backbtn4.TabIndex = 11;
            this.backbtn4.Text = "Back";
            this.backbtn4.UseVisualStyleBackColor = false;
            this.backbtn4.Click += new System.EventHandler(this.Backbtn4_Click);
            // 
            // batchnamelbl
            // 
            this.batchnamelbl.AutoSize = true;
            this.batchnamelbl.Location = new System.Drawing.Point(658, 69);
            this.batchnamelbl.Name = "batchnamelbl";
            this.batchnamelbl.Size = new System.Drawing.Size(97, 13);
            this.batchnamelbl.TabIndex = 12;
            this.batchnamelbl.Text = "Enter Batch Name:";
            // 
            // instructorforbatchlbl
            // 
            this.instructorforbatchlbl.AutoSize = true;
            this.instructorforbatchlbl.Location = new System.Drawing.Point(658, 138);
            this.instructorforbatchlbl.Name = "instructorforbatchlbl";
            this.instructorforbatchlbl.Size = new System.Drawing.Size(118, 13);
            this.instructorforbatchlbl.TabIndex = 13;
            this.instructorforbatchlbl.Text = "Instructor for the Batch:";
            // 
            // SelectClbl
            // 
            this.SelectClbl.AutoSize = true;
            this.SelectClbl.Location = new System.Drawing.Point(658, 200);
            this.SelectClbl.Name = "SelectClbl";
            this.SelectClbl.Size = new System.Drawing.Size(107, 13);
            this.SelectClbl.TabIndex = 14;
            this.SelectClbl.Text = "Select a course Title:";
            // 
            // Sdatelbl
            // 
            this.Sdatelbl.AutoSize = true;
            this.Sdatelbl.Location = new System.Drawing.Point(658, 271);
            this.Sdatelbl.Name = "Sdatelbl";
            this.Sdatelbl.Size = new System.Drawing.Size(58, 13);
            this.Sdatelbl.TabIndex = 15;
            this.Sdatelbl.Text = "Start Date:";
            // 
            // Edatelbl
            // 
            this.Edatelbl.AutoSize = true;
            this.Edatelbl.Location = new System.Drawing.Point(658, 340);
            this.Edatelbl.Name = "Edatelbl";
            this.Edatelbl.Size = new System.Drawing.Size(55, 13);
            this.Edatelbl.TabIndex = 16;
            this.Edatelbl.Text = "End Date:";
            // 
            // datagvBatch
            // 
            this.datagvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvBatch.Location = new System.Drawing.Point(134, 164);
            this.datagvBatch.Name = "datagvBatch";
            this.datagvBatch.Size = new System.Drawing.Size(499, 230);
            this.datagvBatch.TabIndex = 17;
            // 
            // textlbl2
            // 
            this.textlbl2.AutoSize = true;
            this.textlbl2.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textlbl2.Location = new System.Drawing.Point(247, 29);
            this.textlbl2.Name = "textlbl2";
            this.textlbl2.Size = new System.Drawing.Size(325, 53);
            this.textlbl2.TabIndex = 18;
            this.textlbl2.Text = "FARM SCHOOL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // BatchManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(828, 459);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.textlbl2);
            this.Controls.Add(this.datagvBatch);
            this.Controls.Add(this.Edatelbl);
            this.Controls.Add(this.Sdatelbl);
            this.Controls.Add(this.SelectClbl);
            this.Controls.Add(this.instructorforbatchlbl);
            this.Controls.Add(this.batchnamelbl);
            this.Controls.Add(this.Coursetitlecmb);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.InstructorBatchtxt);
            this.Controls.Add(this.Batchnametxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backbtn4);
            this.Controls.Add(this.Showbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.endDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BatchManagementForm";
            this.Text = "Batch Management";
            ((System.ComponentModel.ISupportInitialize)(this.datagvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Batchnametxt;
        private System.Windows.Forms.TextBox InstructorBatchtxt;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.ComboBox Coursetitlecmb;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Showbtn;
        private System.Windows.Forms.Button backbtn4;
        private System.Windows.Forms.Label batchnamelbl;
        private System.Windows.Forms.Label instructorforbatchlbl;
        private System.Windows.Forms.Label SelectClbl;
        private System.Windows.Forms.Label Sdatelbl;
        private System.Windows.Forms.Label Edatelbl;
        private System.Windows.Forms.DataGridView datagvBatch;
        private System.Windows.Forms.Label textlbl2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}