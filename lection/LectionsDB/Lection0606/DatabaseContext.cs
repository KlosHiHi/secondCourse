using Dapper;
using Lection0606.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Lection0606
{
    public static class DatabaseContext
    {
        public static string ConnectionString { get; set; } =
            "Data Source=mssql;Initial Catalog=ispp3101;Persist Security Info=True;User ID=ispp3101;Password=3101;Trust Server Certificate=True";

        public static void ExecuteCommand(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();
            SqlCommand command = new(query, connection);

            //command.CommandType = CommandType.Text;
            //command.CommandType = CommandType.StoredProcedure;
            //command.CommandType = CommandType.TableDirect;

            command.ExecuteNonQuery();
        }

        public static void FindStudent(string name)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = $"select * from students where name = {name}";
            SqlCommand command = new(query, connection);
            command.ExecuteNonQuery();

            //command.Parameters.AddWithValue("@имяПараметра", значение);
            command.Parameters.AddWithValue("@title", "Tetris");

            command.Parameters.Add("@minPrice", SqlDbType.Decimal);
            command.Parameters.Add("@title", SqlDbType.NVarChar, 50);
            command.Parameters[0].Direction = ParameterDirection.Output;
            command.Parameters["@title"].Value = "mario";

            SqlParameter title = new("@minPrice", SqlDbType.Decimal);
            command.Parameters.Add(title);

            command.ExecuteNonQuery();
        }

        public static void ChangePrice(string title, int price)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "UPDATE Game SET Price = @price WHERE Title = @title";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@title", title);

            command.ExecuteNonQuery();
        }

        public static string FindGameTitle(int id)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "SELECT @title = Title FROM Game WHERE Id = @id";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.Add("@title");
            command.Parameters["@title"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            return command.Parameters["@title"].Value.ToString();
        }
    }
}
