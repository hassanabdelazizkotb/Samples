using System;
using System.Data.SQLite;

namespace Registration  
{
    public static class DatabaseSetup
    {
        private const string ConnectionString = "Data Source=users.db;Version=3;";

        public static void CreateDatabase()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserName TEXT UNIQUE NOT NULL,
                        Password TEXT NOT NULL
                    );";
                command.ExecuteNonQuery();
            }
        }
    }
}
