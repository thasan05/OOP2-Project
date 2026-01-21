using HealthCare_Plus.Forms.Dashboard;
using HealthCare_Plus.Models;
using System;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Auth
{
    public partial class StaffLoginForm : Form
    {
        public StaffLoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = email_input.Text.Trim();
            string password = password_input.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email and password is required",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // ✅ HARD-CODED STAFF LOGIN
            if (email.Equals("staff@toothcare.com", StringComparison.OrdinalIgnoreCase)
                && password == "staff123")
            {
                var authUser = AuthUser.Instance;
                authUser.Email = email;
                authUser.FirstName = "Staff";
                authUser.role = "staff";

                StaffDashboard dashboard = new StaffDashboard();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_to_home_lable_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
        private void StaffLoginForm_Load(object sender, EventArgs e)
        {
            // No code needed
        }

    }
}
