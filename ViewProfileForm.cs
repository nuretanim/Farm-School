using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_School
{
    public partial class ViewProfileForm : Form
    {
        public ViewProfileForm()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminForm AdminForm = new AdminForm();
            AdminForm.Show();
            this.Hide();
        }
        private void ShowViewProfilesData()
        {
            string role = Rolecmb.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string query = "";
            if (role == "Farmer")
                query = "SELECT * FROM Farmers";
            else if (role == "Instructor")
                query = "SELECT * FROM Instructors";

            string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt3 = new DataTable();
            sda.Fill(dt3);

            DatagvViewProfiles.DataSource = dt3;
            conn.Close();
        }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            ShowViewProfilesData();
        }
    }
}
