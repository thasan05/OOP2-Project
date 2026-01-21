using System;
using System.Data.SqlClient;

namespace HealthCare_Plus.Models
{
    internal class User
    {
        private string first_name;
        private string last_name;
        private string email;
        private string phone_no;
        private string password;
        private string address;
        private string role;

        
        private readonly string insertQuery =
            "INSERT INTO Users (first_name, last_name, email, password, role) " +
            "OUTPUT INSERTED.ID " +
            "VALUES (@first_name, @last_name, @email, @password, @role);";

        private readonly string updateQuery =
            "UPDATE Users SET " +
            "first_name = @first_name, " +
            "last_name = @last_name, " +
            "email = @email, " +
            "role = @role " +
            "WHERE id = @user_id;";

        private readonly string deleteQuery =
            "DELETE FROM Users WHERE id = @user_id;";

      
        public string FirstName
        {
            get => first_name;
            set => first_name = value;
        }

        public string LastName
        {
            get => last_name;
            set => last_name = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string PhoneNumber
        {
            get => phone_no;
            set => phone_no = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string Role
        {
            get => role;
            set => role = value;
        }

      
        public User() { }

       
        public User(
            string first_name,
            string last_name,
            string email,
            string phone_no,
            string password,
            string address,
            string role
        )
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_no = phone_no;
            this.password = password;
            this.address = address;
            this.role = role;
        }

     
        public SqlCommand GetInsertCommand(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@first_name", this.first_name);
            command.Parameters.AddWithValue("@last_name", this.last_name);
            command.Parameters.AddWithValue("@email", this.email);
            command.Parameters.AddWithValue("@password", this.password); // NO HASH
            command.Parameters.AddWithValue("@role", this.role);
            return command;
        }

    
        public SqlCommand GetUpdateCommand(SqlConnection connection, long user_id)
        {
            SqlCommand command = new SqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@first_name", this.first_name);
            command.Parameters.AddWithValue("@last_name", this.last_name);
            command.Parameters.AddWithValue("@email", this.email);
            command.Parameters.AddWithValue("@role", this.role);
            command.Parameters.AddWithValue("@user_id", user_id);
            return command;
        }

     
        public SqlCommand GetDeleteCommand(SqlConnection connection, long user_id)
        {
            SqlCommand command = new SqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@user_id", user_id);
            return command;
        }
    }
}
