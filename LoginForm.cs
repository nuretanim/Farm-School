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


        private void titlelbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string role = rolecmb.SelectedItem?.ToString();
            string email = emailtxt.Text.Trim();
            string password = passtxt.Text;

            if (string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
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

                // Open Homepage
                 /* Homepage homepage = new Homepage();
                    homepage.Show();*/
                 

                // Hide current (Login) form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            SignupForm signupform = new SignupForm();
            signupform.Show();
            this.Hide();
        }

        private void emailtxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
