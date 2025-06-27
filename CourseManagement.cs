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
    public partial class CourseManagement : Form
    {
        string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";
        public CourseManagement()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Courses (CourseTitle, CourseDescription, Duration, InstructorName) VALUES (@Title, @Description, @Duration, @InstructorName)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", Coursetitletxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Description", Coursedesctxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Duration", Durationtxt.Text.Trim());
                cmd.Parameters.AddWithValue("@InstructorName", Rolecmb2.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Course added successfully!");
            ShowCoursesData();
            ClearInputs();
        }
        private void ShowCoursesData()
        {
            string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM Courses";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);

            DatagvCourse.DataSource = dt2;

            conn.Close();
        }


        private void Backbtn3_Click(object sender, EventArgs e)
        {
            adminForm adminForm = new adminForm();
            adminForm.Show();
            this.Hide();
        }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            ShowCoursesData();
        }
        private void ClearInputs()
        {
            Coursetitletxt.Clear();
            Coursedesctxt.Clear();
            Durationtxt.Clear();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (DatagvCourse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            int courseId = Convert.ToInt32(DatagvCourse.SelectedRows[0].Cells["CourseId"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Courses SET CourseTitle = @Title, CourseDescription = @Description, Duration = @Duration, InstructorName = @Instructor WHERE CourseId = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", Coursetitletxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Description", Coursedesctxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Duration", Durationtxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Instructor", Rolecmb2.Text.Trim());
                cmd.Parameters.AddWithValue("@Id", courseId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Course updated successfully!");
            ShowCoursesData();
            ClearInputs();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (DatagvCourse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            int courseId = Convert.ToInt32(DatagvCourse.SelectedRows[0].Cells["CourseId"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Courses WHERE CourseId = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", courseId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Course deleted successfully!");
                ShowCoursesData();
                ClearInputs();
            }
        } 
    }
}
