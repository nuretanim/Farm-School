using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_School
{
    public partial class BatchManagementForm : Form
    {
        public BatchManagementForm()
        {
            InitializeComponent();
        }

        private void Backbtn4_Click(object sender, EventArgs e)
        {
            AdminForm AdminForm = new AdminForm();
            AdminForm.Show();
            this.Hide();
        }
        string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;IntegratedSecurity=True";

        private void ClearInputs()
        {
            Batchnametxt.Clear();
            Coursetitlecmb.SelectedIndex = -1;
            startDate.Value = DateTime.Now;
            endDate.Value = DateTime.Now;
            InstructorBatchtxt.Clear();
        }
        private void ShowBatches() 
        {
            string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM Batches";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datagvBatch.DataSource = dt;
            
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
                string query = "INSERT INTO Batches (BatchName, CourseTitle, StartDate, EndDate, InstructorName) " +
                               "VALUES (@BatchName, @CourseTitle, @StartDate, @EndDate, @InstructorName)";
            SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BatchName", Batchnametxt.Text.Trim());
                cmd.Parameters.AddWithValue("@CourseTitle", Coursetitlecmb.Text);
                cmd.Parameters.AddWithValue("@StartDate", startDate.Value.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Value.Date);
                cmd.Parameters.AddWithValue("@InstructorName", InstructorBatchtxt.Text.Trim());
                cmd.ExecuteNonQuery();

            MessageBox.Show("Batch added successfully!");
            ShowBatches();
            ClearInputs();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (datagvBatch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a batch to update.");
                return;
            }

            int batchId = Convert.ToInt32(datagvBatch.SelectedRows[0].Cells["BatchId"].Value);

            string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "UPDATE Batches SET BatchName = @BatchName, CourseTitle = @CourseTitle, " +
                               "StartDate = @StartDate, EndDate = @EndDate, InstructorName = @InstructorName " +
                               "WHERE BatchId = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BatchName", Batchnametxt.Text.Trim());
                cmd.Parameters.AddWithValue("@CourseTitle", Coursetitlecmb.Text);
                cmd.Parameters.AddWithValue("@StartDate", startDate.Value.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Value.Date);
                cmd.Parameters.AddWithValue("@InstructorName", InstructorBatchtxt.Text.Trim());
                cmd.Parameters.AddWithValue("@Id", batchId);
                cmd.ExecuteNonQuery();

            MessageBox.Show("Batch updated successfully!");
            ShowBatches();
            ClearInputs();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (datagvBatch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a batch to delete.");
                return;
            }

            int batchId = Convert.ToInt32(datagvBatch.SelectedRows[0].Cells["BatchId"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this batch?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string connectionString = @"Data Source=DESKTOP-1B90EFJ\SQLEXPRESS;Initial Catalog=FarmSchooldb;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "DELETE FROM Batches WHERE BatchId = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", batchId);
                 cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Batch deleted successfully!");
                ShowBatches();
                ClearInputs();
            }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            ShowBatches();
        }
    }
}

