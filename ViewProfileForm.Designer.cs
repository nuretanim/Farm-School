namespace Farm_School
{
    partial class ViewProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProfileForm));
            this.Rolecmb = new System.Windows.Forms.ComboBox();
            this.DatagvViewProfiles = new System.Windows.Forms.DataGridView();
            this.Showbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.textlbl2 = new System.Windows.Forms.Label();
            this.Rolelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatagvViewProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // Rolecmb
            // 
            this.Rolecmb.FormattingEnabled = true;
            this.Rolecmb.Items.AddRange(new object[] {
            "Farmer",
            "Instructor"});
            this.Rolecmb.Location = new System.Drawing.Point(85, 117);
            this.Rolecmb.Name = "Rolecmb";
            this.Rolecmb.Size = new System.Drawing.Size(121, 21);
            this.Rolecmb.TabIndex = 0;
            // 
            // DatagvViewProfiles
            // 
            this.DatagvViewProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagvViewProfiles.Location = new System.Drawing.Point(85, 160);
            this.DatagvViewProfiles.Name = "DatagvViewProfiles";
            this.DatagvViewProfiles.Size = new System.Drawing.Size(651, 234);
            this.DatagvViewProfiles.TabIndex = 1;
            // 
            // Showbtn
            // 
            this.Showbtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Showbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showbtn.Location = new System.Drawing.Point(656, 110);
            this.Showbtn.Name = "Showbtn";
            this.Showbtn.Size = new System.Drawing.Size(80, 33);
            this.Showbtn.TabIndex = 10;
            this.Showbtn.Text = "Show";
            this.Showbtn.UseVisualStyleBackColor = false;
            this.Showbtn.Click += new System.EventHandler(this.Showbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.backbtn.Location = new System.Drawing.Point(735, 413);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(77, 30);
            this.backbtn.TabIndex = 11;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // textlbl2
            // 
            this.textlbl2.AutoSize = true;
            this.textlbl2.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textlbl2.Location = new System.Drawing.Point(250, 38);
            this.textlbl2.Name = "textlbl2";
            this.textlbl2.Size = new System.Drawing.Size(325, 53);
            this.textlbl2.TabIndex = 20;
            this.textlbl2.Text = "FARM SCHOOL";
            // 
            // Rolelbl
            // 
            this.Rolelbl.AutoSize = true;
            this.Rolelbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rolelbl.Location = new System.Drawing.Point(82, 87);
            this.Rolelbl.Name = "Rolelbl";
            this.Rolelbl.Size = new System.Drawing.Size(39, 17);
            this.Rolelbl.TabIndex = 21;
            this.Rolelbl.Text = "Role";
            // 
            // ViewProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(824, 455);
            this.Controls.Add(this.Rolelbl);
            this.Controls.Add(this.textlbl2);
            this.Controls.Add(this.Showbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.DatagvViewProfiles);
            this.Controls.Add(this.Rolecmb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewProfileForm";
            this.Text = "ViewProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.DatagvViewProfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Rolecmb;
        private System.Windows.Forms.DataGridView DatagvViewProfiles;
        private System.Windows.Forms.Button Showbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label textlbl2;
        private System.Windows.Forms.Label Rolelbl;
    }
}