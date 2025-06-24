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
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.titlelbl.Font = new System.Drawing.Font("Britannic Bold", 35F);
            this.titlelbl.ForeColor = System.Drawing.Color.Black;
            this.titlelbl.Location = new System.Drawing.Point(269, 87);
            this.titlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(318, 52);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "FARM SCHOOL";
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(390, 214);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(150, 22);
            this.emailtxt.TabIndex = 2;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.BackColor = System.Drawing.Color.Transparent;
            this.emaillbl.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.emaillbl.ForeColor = System.Drawing.Color.Black;
            this.emaillbl.Location = new System.Drawing.Point(293, 215);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(57, 21);
            this.emaillbl.TabIndex = 3;
            this.emaillbl.Text = "E-mail";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.BackColor = System.Drawing.Color.Transparent;
            this.passlbl.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.passlbl.Location = new System.Drawing.Point(293, 268);
            this.passlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(84, 21);
            this.passlbl.TabIndex = 4;
            this.passlbl.Text = "Password";
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.loginbtn.Location = new System.Drawing.Point(377, 332);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(88, 25);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Log In";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.Loginbtn_Click_1);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(390, 269);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(150, 22);
            this.passtxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(293, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Don\'t Have an Account ?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.InfoText;
            this.linkLabel1.Location = new System.Drawing.Point(468, 383);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 19);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign up";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(153)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(824, 455);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.titlelbl);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.MaskedTextBox emailtxt;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

