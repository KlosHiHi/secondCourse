using Microsoft.Data.Sqlite;
using System.Data;

namespace SqliteLibrary
{
    public static class DataAccessLayer
    {
        public static string DataBaseFilePath { get; set; } 
            = "C:\\Users\\Вячеслав\\Desktop\\5\\programming and web-design\\COURSE 2\\labwork tier2\\LabWork45\\MsSqlLibrary\\ClientConsole\\testdb.sqlite";

        public static List<Game> Games = new List<Game>();

        public static string ConnectionString
        { 
            get => $"Data Source={DataBaseFilePath}";
        }

        public static object GetScalarValue(string query)
        {
            try
            {
                using SqliteConnection connection = new(ConnectionString);
                connection.Open();

                SqliteCommand command = new(query, connection);

                return command.ExecuteScalar();
            }
            catch
            {
                return "Ошибка запроса к SQLite";
            }
        }

        public static SqliteDataReader GetReader(string query)
        {
            using SqliteConnection connection = new(ConnectionString);
            connection.Open();
            SqliteCommand command = new(query, connection);

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
            var reader = GetReader(query);

            DataTable dataTable = new(tableName);
            dataTable.Load(reader);

            return dataTable;
        }
    }
}
