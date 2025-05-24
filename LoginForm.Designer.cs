namespace Farm_School
{
    partial class LoginForm
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
            this.emailtxt = new System.Windows.Forms.MaskedTextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.signupbtn = new System.Windows.Forms.Button();
            this.rolelbl = new System.Windows.Forms.Label();
            this.rolecmb = new System.Windows.Forms.ComboBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(351, 88);
            this.titlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(233, 33);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "FARM SCHOOL";
            this.titlelbl.Click += new System.EventHandler(this.titlelbl_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(427, 248);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(148, 22);
            this.emailtxt.TabIndex = 2;
            this.emailtxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.emailtxt_MaskInputRejected);
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.emaillbl.Location = new System.Drawing.Point(313, 247);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(48, 19);
            this.emaillbl.TabIndex = 3;
            this.emaillbl.Text = "E-mail";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(313, 299);
            this.passlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(69, 19);
            this.passlbl.TabIndex = 4;
            this.passlbl.Text = "Password";
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.loginbtn.Location = new System.Drawing.Point(517, 373);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(88, 28);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Log In";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // signupbtn
            // 
            this.signupbtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.Location = new System.Drawing.Point(357, 373);
            this.signupbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(88, 28);
            this.signupbtn.TabIndex = 6;
            this.signupbtn.Text = "Sign up";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // rolelbl
            // 
            this.rolelbl.AutoSize = true;
            this.rolelbl.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rolelbl.Location = new System.Drawing.Point(313, 200);
            this.rolelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Size = new System.Drawing.Size(37, 19);
            this.rolelbl.TabIndex = 8;
            this.rolelbl.Text = "Role";
            // 
            // rolecmb
            // 
            this.rolecmb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolecmb.FormattingEnabled = true;
            this.rolecmb.Items.AddRange(new object[] {
            "Farmer",
            "Instructor",
            "Admin"});
            this.rolecmb.Location = new System.Drawing.Point(427, 201);
            this.rolecmb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rolecmb.Name = "rolecmb";
            this.rolecmb.Size = new System.Drawing.Size(148, 23);
            this.rolecmb.TabIndex = 9;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(427, 300);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(148, 22);
            this.passtxt.TabIndex = 1;
            this.passtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(153)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(935, 516);
            this.Controls.Add(this.rolecmb);
            this.Controls.Add(this.rolelbl);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.titlelbl);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.MaskedTextBox emailtxt;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Label rolelbl;
        private System.Windows.Forms.ComboBox rolecmb;
        private System.Windows.Forms.TextBox passtxt;
    }
}

