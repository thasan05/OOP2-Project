using System;
using System.Windows.Forms;
using HealthCare_Plus.Forms.Dashboard.Admin;

namespace HealthCare_Plus.Forms.Auth
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            

            string email = email_input.Text.Trim();
            string password = password_input.Text.Trim();

            if (email == "admin@toothcare.com" && password == "admin123")
            {
                

                new AdminDashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("LOGIN FAILED!");
            }
        }

        private void back_to_home_lable_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
