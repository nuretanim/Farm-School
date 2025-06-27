using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_School
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void LinkLabel1_LinkClicked(object sender, EventArgs e)
        {
           
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signupform = new SignupForm();
            signupform.Show();
            this.Hide();
        }

        private void Loginbtn_Click_1(object sender, EventArgs e)
        {
            string email = emailtxt.Text.Trim();
            string password = passtxt.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simulated check – replace with actual user credential check
            if (email == emailtxt.Text && email == emailtxt.Text)
            {
                MessageBox.Show("Successfully Logged in");

                // Open Admin dashboard
                if (email == "admin@farmschool.com" && password == "admin123")
                {
                    AdminForm AdminForm = new AdminForm();
                    AdminForm.Show();
                    // Hide (Login) form
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
