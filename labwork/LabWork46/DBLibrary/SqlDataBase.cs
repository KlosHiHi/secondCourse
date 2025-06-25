using Microsoft.Data.SqlClient;

namespace DBLibrary
{
    public class SqlDataBase : IDataBase
    {
        private readonly string _connectionString;

        public SqlDataBase(string serverName, string dataBase, string userLogin, string password)
        {
            SqlConnectionStringBuilder builder = new()
            {
                DataSource = serverName,
                InitialCatalog = dataBase,
                UserID = userLogin,
                Password = password,
                TrustServerCertificate = true,
            };
            _connectionString = builder.ConnectionString;
        }

        public int ExecuteQuery(string query)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();
            SqlCommand command = new(query, connection);

            return command.ExecuteNonQuery();
        }

        public bool UpdateGame(int id, string newTitle, double newPrice)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string query = $"UPDATE Game SET Title = '{newTitle}', Price = {newPrice} WHERE Id = {id}";
            SqlCommand command = new(query, connection);

            return command.ExecuteNonQuery() > 0;
        }

        public bool InsertGame(string Title, double Price, DateTime publicationYear)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string query = "INSERT INTO Game (Title, Price, PublicationYear) VALUES(@title, @price, @publicationYear)";

            SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@title", Title);
            command.Parameters.AddWithValue("@price", Price);
            command.Parameters.AddWithValue("@publicationYear", publicationYear);

            return command.ExecuteNonQuery() > 0;
        }
    }
}
