using System;
using System.Data.SQLite;

namespace Registration
{
    public class UserRepository
    {
        private const string ConnectionString = "Data Source=users.db;Version=3;";

        public bool ValidateUser(string userName, string password)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM Users WHERE UserName = @userName AND Password = @password";
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@password", password);

                long count = (long)command.ExecuteScalar();
                return count > 0;
            }
        }

        public bool UserExists(string userName)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM Users WHERE UserName = @userName";
                command.Parameters.AddWithValue("@userName", userName);

                long count = (long)command.ExecuteScalar();
                return count > 0;
            }
        }

        public void AddUser(string userName, string password)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Users (UserName, Password) VALUES (@userName, @password)";
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
            }
        }
    }
}
