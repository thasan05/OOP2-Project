namespace DMS
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelPatients = new System.Windows.Forms.Panel();
            this.lblPatients = new System.Windows.Forms.Label();
            this.panelAppointments = new System.Windows.Forms.Panel();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.panelBilling = new System.Windows.Forms.Panel();
            this.lblBilling = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelPatients.SuspendLayout();
            this.panelAppointments.SuspendLayout();
            this.panelBilling.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 80);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Dental Clinic Management System";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(25, 50);
            this.lblWelcome.Text = "Welcome, Admin 👋";
            // 
            // panelPatients
            // 
            this.panelPatients.BackColor = System.Drawing.Color.White;
            this.panelPatients.Controls.Add(this.lblPatients);
            this.panelPatients.Location = new System.Drawing.Point(80, 140);
            this.panelPatients.Size = new System.Drawing.Size(200, 120);
            // 
            // lblPatients
            // 
            this.lblPatients.AutoSize = true;
            this.lblPatients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPatients.ForeColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.lblPatients.Location = new System.Drawing.Point(50, 45);
            this.lblPatients.Text = "Patients";
            // 
            // panelAppointments
            // 
            this.panelAppointments.BackColor = System.Drawing.Color.White;
            this.panelAppointments.Controls.Add(this.lblAppointments);
            this.panelAppointments.Location = new System.Drawing.Point(350, 140);
            this.panelAppointments.Size = new System.Drawing.Size(200, 120);
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAppointments.ForeColor = System.Drawing.Color.FromArgb(67, 160, 71);
            this.lblAppointments.Location = new System.Drawing.Point(25, 45);
            this.lblAppointments.Text = "Appointments";
            // 
            // panelBilling
            // 
            this.panelBilling.BackColor = System.Drawing.Color.White;
            this.panelBilling.Controls.Add(this.lblBilling);
            this.panelBilling.Location = new System.Drawing.Point(620, 140);
            this.panelBilling.Size = new System.Drawing.Size(200, 120);
            // 
            // lblBilling
            // 
            this.lblBilling.AutoSize = true;
            this.lblBilling.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBilling.ForeColor = System.Drawing.Color.FromArgb(251, 140, 0);
            this.lblBilling.Location = new System.Drawing.Point(60, 45);
            this.lblBilling.Text = "Billing";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(229, 57, 53);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(760, 450);
            this.btnLogout.Size = new System.Drawing.Size(100, 40);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Home
            // 
            this.BackColor = System.Drawing.Color.FromArgb(245, 250, 255);
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelBilling);
            this.Controls.Add(this.panelAppointments);
            this.Controls.Add(this.panelPatients);
            this.Controls.Add(this.panelTop);
            this.Name = "Home";
            this.Text = "Dashboard";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelPatients.ResumeLayout(false);
            this.panelPatients.PerformLayout();
            this.panelAppointments.ResumeLayout(false);
            this.panelAppointments.PerformLayout();
            this.panelBilling.ResumeLayout(false);
            this.panelBilling.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelPatients;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.Panel panelAppointments;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Panel panelBilling;
        private System.Windows.Forms.Label lblBilling;
        private System.Windows.Forms.Button btnLogout;
    }
}
