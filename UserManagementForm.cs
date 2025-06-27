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
using System.Data.SqlClient;

namespace Farm_School
{
    public partial class UserManagementForm : Form
    {
        //DataTable dt = new DataTable();
        public UserManagementForm() => InitializeComponent();
        private void ShowUserData() {
            string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM Users";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            datagvUser.DataSource = dt;

            conn.Close();
        }
        private void Backbtn1_Click(object sender, EventArgs e)
        {
            adminForm adminForm = new adminForm();
            adminForm.Show();
            this.Hide();
        }

        private void Show1btn_Click(object sender, EventArgs e)
        {
            ShowUserData();
        }
        private void ClearInputs()
        {
            Nametxt.Clear();
            Emailtxt.Clear();
            Rolecmb.SelectedIndex = -1;
        }

        private void Updatebtn1_Click(object sender, EventArgs e)
        {
            if (datagvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            int selectedIndex = datagvUser.SelectedRows[0].Index;

            // Get ID of selected user
            int userId = Convert.ToInt32(datagvUser.SelectedRows[0].Cells["Id"].Value);

            // Update values in the database
            string name = Nametxt.Text.Trim();
            string email = Emailtxt.Text.Trim();
            string role = Rolecmb.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields before updating.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Users SET Name = @Name, Email = @Email, Role = @Role WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@Id", userId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("User updated successfully!");
            ShowUserData();
            ClearInputs();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string name = Nametxt.Text.Trim();
            string email = Emailtxt.Text.Trim();
            string role = Rolecmb.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields to add a user.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Users (Name, Email, Role) VALUES (@Name, @Email, @Role)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("User added successfully!");
            ShowUserData();
            ClearInputs();
        }

        private void Deletebtn1_Click(object sender, EventArgs e)
        {
            if (datagvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int userId = Convert.ToInt32(datagvUser.SelectedRows[0].Cells["Id"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Users WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", userId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User deleted successfully!");
                ShowUserData();
                ClearInputs();
            }
        }
    }
}

