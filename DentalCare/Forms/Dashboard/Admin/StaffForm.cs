using System;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    public partial class StaffForm : Form
    {
        private bool isRowSelected = false;

        public StaffForm()
        {
            InitializeComponent();

            this.Load += StaffForm_Load;

            Add_btn.Click += Add_btn_Click;
            Update_btn.Click += Update_btn_Click;
            Delete_btn.Click += Delete_btn_Click;
            Reset_btn.Click += Reset_btn_Click;

            StaffDataGridView.CellDoubleClick += StaffDataGridView_CellDoubleClick;

            Add_btn.Enabled = true;
            Update_btn.Enabled = false;
            Delete_btn.Enabled = false;

            Add_btn.Cursor = Cursors.Hand;
            Update_btn.Cursor = Cursors.Hand;
            Delete_btn.Cursor = Cursors.Hand;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            Add_btn.Enabled = true;
            Update_btn.Enabled = false;
            Delete_btn.Enabled = false;

            Add_btn.BringToFront();
            Update_btn.BringToFront();
            Delete_btn.BringToFront();
            Reset_btn.BringToFront();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADD CLICK WORKING", "OK");
            ResetInputs();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (!isRowSelected)
            {
                MessageBox.Show("Select a row first");
                return;
            }

            MessageBox.Show("UPDATE CLICK WORKING", "OK");
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (!isRowSelected)
            {
                MessageBox.Show("Select a row first");
                return;
            }

            MessageBox.Show("DELETE CLICK WORKING", "OK");
            ResetInputs();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RESET CLICK WORKING", "OK");
            ResetInputs();
        }

        private void StaffDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            isRowSelected = true;

            Update_btn.Enabled = true;
            Delete_btn.Enabled = true;

            MessageBox.Show("ROW SELECTED", "OK");
        }

        private void ResetInputs()
        {
            First_name_input.Text = "";
            Last_name_input.Text = "";
            Email_input.Text = "";
            Phone_no_input.Text = "";
            Address_input.Text = "";
            Password_input.Text = "";
            RoleComoboBox.SelectedItem = null;

            isRowSelected = false;
            Update_btn.Enabled = false;
            Delete_btn.Enabled = false;
        }
    }
}
