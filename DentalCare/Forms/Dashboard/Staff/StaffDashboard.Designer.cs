namespace HealthCare_Plus.Forms.Dashboard
{
    partial class StaffDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.patientsBtn = new System.Windows.Forms.Button();
            this.doctorsBtn = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.app_name_label = new System.Windows.Forms.Label();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.avatarImage = new System.Windows.Forms.PictureBox();
            this.username_label = new System.Windows.Forms.Label();
            this.welcome_text = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.navigationPanel.Controls.Add(this.logout_btn);
            this.navigationPanel.Controls.Add(this.patientsBtn);
            this.navigationPanel.Controls.Add(this.doctorsBtn);
            this.navigationPanel.Controls.Add(this.logoPanel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(267, 940);
            this.navigationPanel.TabIndex = 0;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(0, 882);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(267, 58);
            this.logout_btn.TabIndex = 22;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // patientsBtn
            // 
            this.patientsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.patientsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientsBtn.FlatAppearance.BorderSize = 0;
            this.patientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsBtn.ForeColor = System.Drawing.Color.White;
            this.patientsBtn.Image = global::DentalCare.Properties.Resources.patient_icon;
            this.patientsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsBtn.Location = new System.Drawing.Point(0, 289);
            this.patientsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientsBtn.Name = "patientsBtn";
            this.patientsBtn.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.patientsBtn.Size = new System.Drawing.Size(267, 92);
            this.patientsBtn.TabIndex = 17;
            this.patientsBtn.Text = "Patients";
            this.patientsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientsBtn.UseVisualStyleBackColor = false;
            this.patientsBtn.Click += new System.EventHandler(this.patientsBtn_Click);
            // 
            // doctorsBtn
            // 
            this.doctorsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.doctorsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.doctorsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doctorsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorsBtn.FlatAppearance.BorderSize = 0;
            this.doctorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsBtn.ForeColor = System.Drawing.Color.White;
            this.doctorsBtn.Image = ((System.Drawing.Image)(resources.GetObject("doctorsBtn.Image")));
            this.doctorsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorsBtn.Location = new System.Drawing.Point(0, 197);
            this.doctorsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doctorsBtn.Name = "doctorsBtn";
            this.doctorsBtn.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.doctorsBtn.Size = new System.Drawing.Size(267, 92);
            this.doctorsBtn.TabIndex = 16;
            this.doctorsBtn.Text = "Doctors";
            this.doctorsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.doctorsBtn.UseVisualStyleBackColor = false;
            this.doctorsBtn.Click += new System.EventHandler(this.doctorsBtn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.logoPanel.Controls.Add(this.app_name_label);
            this.logoPanel.Controls.Add(this.logoImage);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(267, 197);
            this.logoPanel.TabIndex = 1;
            // 
            // app_name_label
            // 
            this.app_name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.app_name_label.AutoSize = true;
            this.app_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name_label.ForeColor = System.Drawing.Color.White;
            this.app_name_label.Location = new System.Drawing.Point(71, 153);
            this.app_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.app_name_label.Name = "app_name_label";
            this.app_name_label.Size = new System.Drawing.Size(144, 29);
            this.app_name_label.TabIndex = 17;
            this.app_name_label.Text = "Tooth Care";
            this.app_name_label.Click += new System.EventHandler(this.app_name_label_Click);
            // 
            // logoImage
            // 
            this.logoImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoImage.Image = ((System.Drawing.Image)(resources.GetObject("logoImage.Image")));
            this.logoImage.Location = new System.Drawing.Point(55, 14);
            this.logoImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(160, 134);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(90)))));
            this.headerPanel.Controls.Add(this.avatarImage);
            this.headerPanel.Controls.Add(this.username_label);
            this.headerPanel.Controls.Add(this.welcome_text);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(267, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1359, 106);
            this.headerPanel.TabIndex = 1;
            // 
            // avatarImage
            // 
            this.avatarImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarImage.Image = global::DentalCare.Properties.Resources.user;
            this.avatarImage.Location = new System.Drawing.Point(1284, 14);
            this.avatarImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avatarImage.Name = "avatarImage";
            this.avatarImage.Size = new System.Drawing.Size(57, 54);
            this.avatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarImage.TabIndex = 14;
            this.avatarImage.TabStop = false;
            // 
            // username_label
            // 
            this.username_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(1275, 72);
            this.username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(71, 20);
            this.username_label.TabIndex = 15;
            this.username_label.Text = "System";
            // 
            // welcome_text
            // 
            this.welcome_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcome_text.AutoSize = true;
            this.welcome_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text.ForeColor = System.Drawing.Color.White;
            this.welcome_text.Location = new System.Drawing.Point(420, 39);
            this.welcome_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(199, 29);
            this.welcome_text.TabIndex = 12;
            this.welcome_text.Text = "Staff Dashboard";
            this.welcome_text.Click += new System.EventHandler(this.welcome_text_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(267, 106);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1359, 834);
            this.bodyPanel.TabIndex = 2;
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1626, 940);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.navigationPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StaffDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffDashboard_Load);
            this.navigationPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label app_name_label;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button patientsBtn;
        private System.Windows.Forms.Button doctorsBtn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Label welcome_text;
        private System.Windows.Forms.PictureBox avatarImage;
        private System.Windows.Forms.Label username_label;
    }
}