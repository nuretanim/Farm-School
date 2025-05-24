using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Farm_School
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rolecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = rolecmb.SelectedItem.ToString();
            if (role == "Instructor")
            {
                expertiselbl.Visible = true;
                expertisecmb.Visible = true;
            }
            else
            {
                expertiselbl.Visible=false;
                expertisecmb.Visible=false; 
            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string role = rolecmb.SelectedItem?.ToString();
            string fname = fnametxt.Text;
            string email = emailtxt.Text;
            string password = passtxt.Text;
            string confirmPassword = confirmpasstxt.Text;
            string location = locationtxt.Text;
            string expertise = (expertisecmb.Visible) ? expertisecmb.SelectedItem?.ToString() : null;

            // Only capture expertise if the role is Instructor
            string ifexpertise = "";
            if (role == "Instructor")
            {
                expertise = expertisecmb.SelectedItem?.ToString()?.Trim();

                if (string.IsNullOrWhiteSpace(expertise))
                {
                    MessageBox.Show("Please select an area of expertise for the Instructor.");
                    return;
                }
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(fname) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Registration logic here (e.g., saving to database)
           /* bool success = RegisterUser(role, name, email, password, location, expertise);

            if (success)
            {
                MessageBox.Show("Account created successfully!");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Registration failed. Email may already exist.");
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            LoginForm loginForm = new LoginForm();  
            loginForm.Show();
            this.Close();
        }
    }
}
