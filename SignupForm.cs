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


        private void Rolecmb_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            string role = rolecmb.SelectedItem?.ToString();
            string fname = fnametxt.Text;
            string email = emailtxt.Text;
            string password = passtxt.Text;
            string confirmPassword = confirmpasstxt.Text;
            string location = locationtxt.Text;
            string Expertise = (expertisecmb.Visible) ? expertisecmb.SelectedItem?.ToString() : null;

            // Only capture expertise if the role is Instructor
            if (role == "Instructor")
            {
                Expertise = expertisecmb.SelectedItem?.ToString()?.Trim();

                if (string.IsNullOrWhiteSpace(Expertise))
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

        private void Button1_Click(object sender, EventArgs e)
        {
            
            LoginForm loginForm = new LoginForm();  
            loginForm.Show();
            this.Close();
        }

        private void Emailtxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Rolelbl_Click(object sender, EventArgs e)
        {

        }

        private void Xpertiselbl_Click(object sender, EventArgs e)
        {

        }

        private void Locationlbl_Click(object sender, EventArgs e)
        {

        }

        private void Confirmpasstxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Passtxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Locationtxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Fnametxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Confirmpasslbl_Click(object sender, EventArgs e)
        {

        }

        private void Passlbl_Click(object sender, EventArgs e)
        {

        }

        private void Expertisecmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fnamelbl_Click(object sender, EventArgs e)
        {

        }

        private void Emaillbl_Click(object sender, EventArgs e)
        {

        }
    }
}
