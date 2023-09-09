using System;
using System.Data.SqlClient;

namespace dp_project
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        public static Singleton Instance { get { return lazy.Value; } }

        private string connectionString = "Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True";

        public bool Login(string username, string password, string desiredUserRole)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password AND UserRole = @userrole";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@userrole", desiredUserRole);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        internal bool Login(string text1, string text2)
        {
            throw new NotImplementedException();
        }
    }
}
