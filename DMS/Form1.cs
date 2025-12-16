using System;
using System.Windows.Forms;

namespace DMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(241, 248, 255);

            btnLogin.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;

            lbluname.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            lblpass.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtuname.Text))
            {
                MessageBox.Show("Please enter username");
                txtuname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Please enter password");
                txtpass.Focus();
                return;
            }

            if (txtuname.Text == "admin" && txtpass.Text == "1234")
            {
                MessageBox.Show("Successfully logged in",
                                "Login Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                txtpass.Clear();
                txtpass.Focus();
            }
        }

    }
}
