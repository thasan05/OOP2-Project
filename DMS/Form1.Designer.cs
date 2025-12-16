namespace DMS
{
    partial class Form1
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
            this.lbluname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Location = new System.Drawing.Point(180, 150);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(83, 20);
            this.lbluname.Text = "Username";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(180, 200);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(78, 20);
            this.lblpass.Text = "Password";
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(300, 150);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(150, 26);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(300, 200);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(150, 26);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(300, 260);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluname);
            this.Name = "Form1";
            this.Text = "Dental Clinic Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnLogin;
    }
}
