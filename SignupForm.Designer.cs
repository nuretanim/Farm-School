namespace Farm_School
{
    partial class SignupForm
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
            this.titlelbl = new System.Windows.Forms.Label();
            this.rolecmb = new System.Windows.Forms.ComboBox();
            this.rolelbl = new System.Windows.Forms.Label();
            this.registerbtn = new System.Windows.Forms.Button();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.MaskedTextBox();
            this.passlbl = new System.Windows.Forms.Label();
            this.confirmpasslbl = new System.Windows.Forms.Label();
            this.fnametxt = new System.Windows.Forms.MaskedTextBox();
            this.locationtxt = new System.Windows.Forms.MaskedTextBox();
            this.passtxt = new System.Windows.Forms.MaskedTextBox();
            this.confirmpasstxt = new System.Windows.Forms.MaskedTextBox();
            this.locationlbl = new System.Windows.Forms.Label();
            this.expertiselbl = new System.Windows.Forms.Label();
            this.expertisecmb = new System.Windows.Forms.ComboBox();
            this.btloginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(47, 69);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(255, 33);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "Create a new account";
            // 
            // rolecmb
            // 
            this.rolecmb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolecmb.FormattingEnabled = true;
            this.rolecmb.Items.AddRange(new object[] {
            "Farmer",
            "Instructor",
            "Admin"});
            this.rolecmb.Location = new System.Drawing.Point(400, 142);
            this.rolecmb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rolecmb.Name = "rolecmb";
            this.rolecmb.Size = new System.Drawing.Size(148, 23);
            this.rolecmb.TabIndex = 17;
            this.rolecmb.SelectedIndexChanged += new System.EventHandler(this.rolecmb_SelectedIndexChanged);
            // 
            // rolelbl
            // 
            this.rolelbl.AutoSize = true;
            this.rolelbl.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rolelbl.Location = new System.Drawing.Point(262, 142);
            this.rolelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Size = new System.Drawing.Size(37, 19);
            this.rolelbl.TabIndex = 16;
            this.rolelbl.Text = "Role";
            // 
            // registerbtn
            // 
            this.registerbtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.Location = new System.Drawing.Point(339, 454);
            this.registerbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(132, 28);
            this.registerbtn.TabIndex = 15;
            this.registerbtn.Text = "Create Account";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnamelbl.Location = new System.Drawing.Point(262, 211);
            this.fnamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(72, 19);
            this.fnamelbl.TabIndex = 13;
            this.fnamelbl.Text = "Full Name";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.emaillbl.Location = new System.Drawing.Point(262, 178);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(48, 19);
            this.emaillbl.TabIndex = 12;
            this.emaillbl.Text = "E-mail";
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(400, 175);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(148, 22);
            this.emailtxt.TabIndex = 11;
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(262, 251);
            this.passlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(69, 19);
            this.passlbl.TabIndex = 20;
            this.passlbl.Text = "Password";
            // 
            // confirmpasslbl
            // 
            this.confirmpasslbl.AutoSize = true;
            this.confirmpasslbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasslbl.Location = new System.Drawing.Point(262, 292);
            this.confirmpasslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmpasslbl.Name = "confirmpasslbl";
            this.confirmpasslbl.Size = new System.Drawing.Size(122, 19);
            this.confirmpasslbl.TabIndex = 21;
            this.confirmpasslbl.Text = "Confirm Password";
            // 
            // fnametxt
            // 
            this.fnametxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.Location = new System.Drawing.Point(400, 211);
            this.fnametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(148, 22);
            this.fnametxt.TabIndex = 23;
            // 
            // locationtxt
            // 
            this.locationtxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationtxt.Location = new System.Drawing.Point(400, 335);
            this.locationtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(148, 22);
            this.locationtxt.TabIndex = 24;
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(400, 251);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(148, 22);
            this.passtxt.TabIndex = 26;
            // 
            // confirmpasstxt
            // 
            this.confirmpasstxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasstxt.Location = new System.Drawing.Point(400, 292);
            this.confirmpasstxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmpasstxt.Name = "confirmpasstxt";
            this.confirmpasstxt.PasswordChar = '*';
            this.confirmpasstxt.Size = new System.Drawing.Size(148, 22);
            this.confirmpasstxt.TabIndex = 27;
            // 
            // locationlbl
            // 
            this.locationlbl.AutoSize = true;
            this.locationlbl.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.locationlbl.Location = new System.Drawing.Point(262, 335);
            this.locationlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationlbl.Name = "locationlbl";
            this.locationlbl.Size = new System.Drawing.Size(62, 19);
            this.locationlbl.TabIndex = 28;
            this.locationlbl.Text = "Location";
            // 
            // expertiselbl
            // 
            this.expertiselbl.AutoSize = true;
            this.expertiselbl.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.expertiselbl.Location = new System.Drawing.Point(262, 379);
            this.expertiselbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expertiselbl.Name = "expertiselbl";
            this.expertiselbl.Size = new System.Drawing.Size(65, 19);
            this.expertiselbl.TabIndex = 29;
            this.expertiselbl.Text = "Expertise";
            // 
            // expertisecmb
            // 
            this.expertisecmb.FormattingEnabled = true;
            this.expertisecmb.Items.AddRange(new object[] {
            "Soil Science",
            "Crop Cultivation",
            "Pest Management",
            "Agribusiness",
            "Organic Farming",
            "Farm Technology"});
            this.expertisecmb.Location = new System.Drawing.Point(400, 380);
            this.expertisecmb.Name = "expertisecmb";
            this.expertisecmb.Size = new System.Drawing.Size(148, 21);
            this.expertisecmb.TabIndex = 31;
            // 
            // btloginbtn
            // 
            this.btloginbtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btloginbtn.Location = new System.Drawing.Point(53, 454);
            this.btloginbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btloginbtn.Name = "btloginbtn";
            this.btloginbtn.Size = new System.Drawing.Size(88, 28);
            this.btloginbtn.TabIndex = 32;
            this.btloginbtn.Text = "Back to login";
            this.btloginbtn.UseVisualStyleBackColor = true;
            this.btloginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.btloginbtn);
            this.Controls.Add(this.expertisecmb);
            this.Controls.Add(this.expertiselbl);
            this.Controls.Add(this.locationlbl);
            this.Controls.Add(this.confirmpasstxt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.locationtxt);
            this.Controls.Add(this.fnametxt);
            this.Controls.Add(this.confirmpasslbl);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.rolecmb);
            this.Controls.Add(this.rolelbl);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.fnamelbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.titlelbl);
            this.Name = "Form1";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.ComboBox rolecmb;
        private System.Windows.Forms.Label rolelbl;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.MaskedTextBox emailtxt;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label confirmpasslbl;
        private System.Windows.Forms.MaskedTextBox fnametxt;
        private System.Windows.Forms.MaskedTextBox locationtxt;
        private System.Windows.Forms.MaskedTextBox passtxt;
        private System.Windows.Forms.MaskedTextBox confirmpasstxt;
        private System.Windows.Forms.Label locationlbl;
        private System.Windows.Forms.Label expertiselbl;
        private System.Windows.Forms.ComboBox expertisecmb;
        private System.Windows.Forms.Button btloginbtn;
    }
}