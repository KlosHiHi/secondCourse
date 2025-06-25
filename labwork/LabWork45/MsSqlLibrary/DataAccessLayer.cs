using Microsoft.Data.SqlClient;
using System.Data;

namespace MsSqlLibrary
{
    public static class DataAccessLayer
    {
        public static string ServerName { get; set; } = "mysql";
        public static string DataBase { get; set; } = "ispp3101";
        public static string UserLogin { get; set; } = "ispp3101";
        public static string Password { get; set; } = "3101";

        public static List<Game> Games = new List<Game>();

        public static string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder builder = new()
                {
                    DataSource = ServerName,
                    InitialCatalog = DataBase,
                    UserID = UserLogin,
                    Password = Password,
                    TrustServerCertificate = true,
                };

                return builder.ConnectionString;
            }
        }

        public static object GetScalarValue(string query)
        {
            try
            {
                using SqlConnection connection = new(ConnectionString);
                connection.Open();

                SqlCommand command = new(query, connection);

                return command.ExecuteScalar();
            }
            catch
            {
                return "Ошибка запроса к SQLite";
            }
        }

        public static SqlDataReader GetReader(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();
            SqlCommand command = new(query, connection);

            return command.ExecuteReader();
        }

        public static void UpdateGamesData()
        {
            var reader = GetReader("SELECT * FROM Games;");

            if (reader.HasRows)
                while (reader.Read())
                {
                    Games.Add(new Game
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Title = reader["Title"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                    });
                }
        }

        public static DataTable GetData(string query, string tableName)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlDataAdapter adapter = new(query, connection);
            DataTable dataTable = new(tableName);
            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
