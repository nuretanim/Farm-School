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
    public partial class AnnouncementForm : Form
    {
        public AnnouncementForm()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";
        private void ShowCoursesData()
        {
            string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM Announcements";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);

            DatagvAnnouncement.DataSource = dt2;

            conn.Close();
        }
        private void Showbtn_Click(object sender, EventArgs e)
        {
            ShowCoursesData();
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Announcements (AnnouncementTitle, Notice, DatePosted, PostedBy) " +
                               "VALUES (@Title, @Notice, @DatePosted, @PostedBy)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", Announcementtitletxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Notice", Coursedesctxt.Text.Trim());
                cmd.Parameters.AddWithValue("@DatePosted", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@PostedBy", Postedbytxt.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Announcement added successfully!");
            ShowCoursesData();
            ClearInputs();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (DatagvAnnouncement.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an announcement to update.");
                return;
            }

            int id = Convert.ToInt32(DatagvAnnouncement.SelectedRows[0].Cells["AnnouncementId"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Announcements SET AnnouncementTitle = @Title, Notice = @Notice, " +
                               "DatePosted = @DatePosted, PostedBy = @PostedBy WHERE AnnouncementId = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", Announcementtitletxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Notice", Coursedesctxt.Text.Trim());
                cmd.Parameters.AddWithValue("@DatePosted", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@PostedBy", Postedbytxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Announcement updated successfully!");
            ShowCoursesData();
            ClearInputs();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (DatagvAnnouncement.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an announcement to delete.");
                return;
            }

            int id = Convert.ToInt32(DatagvAnnouncement.SelectedRows[0].Cells["AnnouncementId"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this announcement?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Announcements WHERE AnnouncementId = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Announcement deleted successfully!");
                ShowCoursesData();
                ClearInputs();
            }
        }
        private void ClearInputs()
        {
            Announcementtitletxt.Clear();
            Coursedesctxt.Clear();
            dateTimePicker1.Value = DateTime.Now;
            Postedbytxt.Clear();
        }


        private void backbtn3_Click(object sender, EventArgs e)
        {
            AdminForm AdminForm = new AdminForm();
            AdminForm.Show();
            this.Hide();
        }
    }
}
