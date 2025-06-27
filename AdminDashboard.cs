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
using Org.BouncyCastle.Tls;

namespace Farm_School
{
    public partial class AdminForm : Form
    {
        public object Rolecmb { get; private set; }

        public AdminForm()
        {
            InitializeComponent();
        }

        private void Announcebtn_Click(object sender, EventArgs e)
        {
            AnnouncementForm announcementForm = new AnnouncementForm();
            announcementForm.Show();
            this.Hide();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void UserMbtn_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.Show();
            this.Hide();
        }

        private void CourseMbtn_Click(object sender, EventArgs e)
        {
            CourseManagement courseManagement = new CourseManagement();
            courseManagement.Show();
            this.Hide();
        }

        private void BatchMbtn_Click(object sender, EventArgs e)
        {
            BatchManagementForm batchManagementForm = new BatchManagementForm();
            batchManagementForm.Show();
            this.Hide();
        }

        private void viewprofilesbtn_Click(object sender, EventArgs e)
        {

            ViewProfileForm viewprofileform = new ViewProfileForm();
            viewprofileform.Show();
            this.Hide();

        }
    }
}
