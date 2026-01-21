using HealthCare_Plus.Utils;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Staff
{
    public partial class DoctorForm : Form
    {
        DataGridView doctorGridView;
        private string NameText = null;
        private string EmailText = null;
        private string SpecializationText = null;
        private string LocationText = null;
        private string selectQuery =
            "SELECT Users.id, Users.first_name, Users.last_name, Users.email, DoctorProfiles.qualification, DoctorProfiles.specialization, DoctorProfiles.contact_no, DoctorProfiles.location, DoctorProfiles.home_address,DoctorProfiles.hospital_address FROM Users INNER JOIN DoctorProfiles ON Users.id = DoctorProfiles.user_id";

        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            doctorGridView = doctorsDataGridView;
            LoadDoctorsData();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            SetInputValues();

            if (
                string.IsNullOrEmpty(NameText)
                && string.IsNullOrEmpty(EmailText)
                && string.IsNullOrEmpty(SpecializationText)
                && string.IsNullOrEmpty(LocationText)
            )
            {
                MessageBox.Show("Please enter a search term", "Empty Search", default, MessageBoxIcon.Error);
                return;
            }

            string searchQuery = selectQuery + " WHERE 1=1";

            DBCon dBCon = new DBCon();
            SqlConnection sqlCon = dBCon.SqlConnection;

            try
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(searchQuery, sqlCon);

                if (!string.IsNullOrEmpty(EmailText))
                {
                    cmd.CommandText += " AND Users.email = @email";
                    cmd.Parameters.AddWithValue("@email", EmailText);
                }

                if (!string.IsNullOrEmpty(NameText))
                {
                    cmd.CommandText += " AND Users.first_name LIKE @name";
                    cmd.Parameters.AddWithValue("@name", "%" + NameText + "%");
                }

                if (!string.IsNullOrEmpty(SpecializationText))
                {
                    cmd.CommandText += " AND DoctorProfiles.specialization LIKE @specialization";
                    cmd.Parameters.AddWithValue("@specialization", "%" + SpecializationText + "%");
                }

                if (!string.IsNullOrEmpty(LocationText))
                {
                    cmd.CommandText += " AND DoctorProfiles.location LIKE @location";
                    cmd.Parameters.AddWithValue("@location", "%" + LocationText + "%");
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTabel = new DataTable();
                adapter.Fill(dataTabel);
                sqlCon.Close();

                if (dataTabel.Rows.Count == 0)
                {
                    MessageBox.Show("No doctors found", "No Results", default, MessageBoxIcon.Information);
                    return;
                }

                doctorGridView.DataSource = dataTabel;
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                Console.WriteLine(ex.Message);
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            ResetInputFields();
            LoadDoctorsData();
        }

        private void LoadDoctorsData()
        {
            DBCon dBCon = new DBCon();
            SqlConnection sqlCon = dBCon.SqlConnection;

            try
            {
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, sqlCon);
                DataTable dataTabel = new DataTable();
                adapter.Fill(dataTabel);
                sqlCon.Close();
                doctorGridView.DataSource = dataTabel;
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                Console.WriteLine(ex.Message);
            }
        }

        private void SetInputValues()
        {
            NameText = Name_input.Text;
            EmailText = Email_input.Text;
            SpecializationText = Specialization_Input.Text;
            LocationText = Location_input.Text;
        }

        private void ResetInputFields()
        {
            Name_input.Text = "";
            Email_input.Text = "";
            Specialization_Input.SelectedItem = null;
            Location_input.SelectedItem = null;
        }
    }
}
