namespace Farm_School
{
    partial class adminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSSIGNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCHEDULECOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bATCHMANAGEMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNNOUNCEMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWFARMERSPROFILESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageInstructorToolStripMenuItem,
            this.coursesViewToolStripMenuItem,
            this.bATCHMANAGEMENTToolStripMenuItem,
            this.aNNOUNCEMENTToolStripMenuItem,
            this.vIEWFARMERSPROFILESToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageInstructorToolStripMenuItem
            // 
            this.manageInstructorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.dELETEToolStripMenuItem,
            this.dELETEToolStripMenuItem1});
            this.manageInstructorToolStripMenuItem.Name = "manageInstructorToolStripMenuItem";
            this.manageInstructorToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.manageInstructorToolStripMenuItem.Text = "User Management";
            this.manageInstructorToolStripMenuItem.Click += new System.EventHandler(this.ManageInstructorToolStripMenuItem_Click);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aDDToolStripMenuItem.Text = "EDIT";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.ADDToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dELETEToolStripMenuItem.Text = "ADD";
            // 
            // dELETEToolStripMenuItem1
            // 
            this.dELETEToolStripMenuItem1.Name = "dELETEToolStripMenuItem1";
            this.dELETEToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dELETEToolStripMenuItem1.Text = "DELETE";
            // 
            // coursesViewToolStripMenuItem
            // 
            this.coursesViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cREATEToolStripMenuItem,
            this.aSSIGNToolStripMenuItem,
            this.sCHEDULECOURSEToolStripMenuItem});
            this.coursesViewToolStripMenuItem.Name = "coursesViewToolStripMenuItem";
            this.coursesViewToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.coursesViewToolStripMenuItem.Text = "Course Management";
            // 
            // cREATEToolStripMenuItem
            // 
            this.cREATEToolStripMenuItem.Name = "cREATEToolStripMenuItem";
            this.cREATEToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cREATEToolStripMenuItem.Text = "CREATE";
            // 
            // aSSIGNToolStripMenuItem
            // 
            this.aSSIGNToolStripMenuItem.Name = "aSSIGNToolStripMenuItem";
            this.aSSIGNToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.aSSIGNToolStripMenuItem.Text = "ASSIGN";
            // 
            // sCHEDULECOURSEToolStripMenuItem
            // 
            this.sCHEDULECOURSEToolStripMenuItem.Name = "sCHEDULECOURSEToolStripMenuItem";
            this.sCHEDULECOURSEToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sCHEDULECOURSEToolStripMenuItem.Text = "SCHEDULE COURSES";
            // 
            // bATCHMANAGEMENTToolStripMenuItem
            // 
            this.bATCHMANAGEMENTToolStripMenuItem.Name = "bATCHMANAGEMENTToolStripMenuItem";
            this.bATCHMANAGEMENTToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.bATCHMANAGEMENTToolStripMenuItem.Text = "Batch Management";
            // 
            // aNNOUNCEMENTToolStripMenuItem
            // 
            this.aNNOUNCEMENTToolStripMenuItem.Name = "aNNOUNCEMENTToolStripMenuItem";
            this.aNNOUNCEMENTToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.aNNOUNCEMENTToolStripMenuItem.Text = "ANNOUNCEMENT";
            // 
            // vIEWFARMERSPROFILESToolStripMenuItem
            // 
            this.vIEWFARMERSPROFILESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.farmerToolStripMenuItem,
            this.instructorToolStripMenuItem});
            this.vIEWFARMERSPROFILESToolStripMenuItem.Name = "vIEWFARMERSPROFILESToolStripMenuItem";
            this.vIEWFARMERSPROFILESToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.vIEWFARMERSPROFILESToolStripMenuItem.Text = "View Profiles";
            // 
            // farmerToolStripMenuItem
            // 
            this.farmerToolStripMenuItem.Name = "farmerToolStripMenuItem";
            this.farmerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.farmerToolStripMenuItem.Text = "Farmer";
            // 
            // instructorToolStripMenuItem
            // 
            this.instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            this.instructorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instructorToolStripMenuItem.Text = "Instructor";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 264);
            this.dataGridView1.TabIndex = 1;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminForm";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cREATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSSIGNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCHEDULECOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bATCHMANAGEMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNNOUNCEMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWFARMERSPROFILESToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem farmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
    }
}