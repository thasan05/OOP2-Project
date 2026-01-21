using HealthCare_Plus.Forms.Dashboard.Staff;
using HealthCare_Plus.Forms.Dashboard.Admin;
using HealthCare_Plus.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard
{
    public partial class StaffDashboard : Form
    {
        private AuthUser authUser = AuthUser.Instance;
        private Button currentButton;
        private Form activeForm;

        public StaffDashboard()
        {
            InitializeComponent();
        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            if (authUser == null)
            {
                MessageBox.Show("You are not loged in", "Unathorized", default, MessageBoxIcon.Error);
                return;
            }

            username_label.Text = authUser.FirstName;
            OpenChildForm(new DoctorForm(), doctorsBtn);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            authUser.Logout();
            Home homePage = new Home();
            this.Hide();
            homePage.Show();
        }

        private void doctorsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoctorForm(), sender);
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PatientsForm(), sender);
        }

        private void appoinmentsBtn_Click(object sender, EventArgs e)
        {
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
        }

        private void invoiceBtn_Click(object sender, EventArgs e)
        {
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButtons();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(255, 122, 79);
                }
            }
        }

        private void DisableButtons()
        {
            foreach (Control btn in navigationPanel.Controls)
            {
                if (btn.Name != "logout_btn")
                {
                    if (btn.GetType() == typeof(Button))
                    {
                        btn.BackColor = Color.FromArgb(2, 36, 77);
                    }
                }
            }
        }

        private void OpenChildForm(Form form, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActiveButton(btnSender);
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.bodyPanel.Controls.Add(form);
            this.bodyPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void welcome_text_Click(object sender, EventArgs e)
        {
        }

        private void app_name_label_Click(object sender, EventArgs e)
        {
        }
    }
}
