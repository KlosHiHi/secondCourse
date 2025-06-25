using Microsoft.Data.Sqlite;

namespace DBLibrary
{
    public class SqliteDataBase : IDataBase
    {
        private readonly string _connectionString;

        public SqliteDataBase(string dataBaseFilePath)
        {
            SqliteConnectionStringBuilder builder = new()
            {
                DataSource = dataBaseFilePath,
            };
            _connectionString = builder.ConnectionString;
        }

        public int ExecuteQuery(string query)
        {
            using SqliteConnection connection = new(_connectionString);
            connection.Open();
            SqliteCommand command = new(query, connection);

            return command.ExecuteNonQuery();
        }

        public bool UpdateGame(int id, string newTitle, double newPrice)
        {
            using SqliteConnection connection = new(_connectionString);
            connection.Open();

            string query = $"UPDATE Game SET Title = '{newTitle}', Price = {newPrice} WHERE Id = {id}";
            SqliteCommand command = new(query, connection);

            return command.ExecuteNonQuery() > 0;
        }

        public bool InsertGame(string Title, double Price, DateTime publicationYear)
        {
            using SqliteConnection connection = new(_connectionString);
            connection.Open();

            string query = "INSERT INTO Game (Title, Price, PublicationYear) VALUES(@title, @price, @publicationYear)";

            SqliteCommand command = new(query, connection);

            command.Parameters.AddWithValue("@title", Title);
            command.Parameters.AddWithValue("@price", Price);
            command.Parameters.AddWithValue("@publicationYear", publicationYear);

            return command.ExecuteNonQuery() > 0;
        }
    }
}
