using Lection0605;
using Lection0606;
using Lection0606.Database;
using Lection0606.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System.Data;

Console.WriteLine("ADO.NET");

DatabaseContext.ChangePrice("Robert", 777);

//var title = DatabaseContext.FindGameTitle(1);

//var reviews = DatabaseContext.GetReviews();
//var review = DatabaseContext.GetReview(2);

//Console.WriteLine();

string connectionString
    = "Data Source=mssql;Initial Catalog=ispp3101;Persist Security Info=True;User ID=ispp3101;Password=3101Trust Server Certificate=True";

IDataBaseFactory factory = new MsSqlFactory(connectionString);
ReviewRepository repository = new(factory);

var reviews = repository.GetReviews();
var review = repository.GetReview(2);

void TestMssql()
{
    Console.WriteLine("Microsoft SQL Server");

    string connectionString =
        "Data Source=mssql;Initial Catalog=ispp3101;Persist Security Info=True;User ID=ispp3101;Password=3101;Trust Server Certificate=True";

    SqlConnectionStringBuilder builder = new()
    {
        DataSource = "mssql",        // server
        InitialCatalog = "ispp3101", // db
        UserID = "ispp3101",         // login
        Password = "3101",
        TrustServerCertificate = true
    };
    connectionString = builder.ConnectionString;

    using SqlConnection connection = new(connectionString);
    connection.Open();

    string query = "UPDATE Game SET Price-=0.01";
    SqlCommand command = new(query, connection);

    //command.ExecuteNonQuery();                 //DDL
    //int rowsCount = command.ExecuteNonQuery(); //DML

    //command = new(query, connection);
    //object result = command.ExecuteScalar();
    //var price = Convert.ToDouble(command.ExecuteScalar());
    //decimal price = Convert.ToDecimal(command.ExecuteScalar);
    //string title = command.ExecuteScalar().ToString();

    query = "SELECT * FROM Game";
    command = new(query, connection);
    var reader = command.ExecuteReader();

    DataTable schema = reader.GetSchemaTable();
    Console.WriteLine();
    //SqlDataAdapter adapter = new(query, connection);
    //DataTable table = new();
    //adapter.Fill(table);

    //SqlCommandBuilder commandBuilder = new(adapter);
    //adapter.Update(table);
    //table.Clear();
    //adapter.Fill(table);

    //command = new(query, connection);
    //var reader = command.ExecuteReader();

    //DataTable table = new("games");
    //table.Load(reader);

    var columnsCount = reader.FieldCount;

    List<Game> games = new();

    while (reader.Read())
    {
        //games.Add(new()
        //{
        //    Id = Convert.ToInt32(reader["Id"]),
        //    Title = reader["Title"].ToString(),
        //    Price = Convert.ToDecimal(reader["Price"])
        //});

        //var id = reader.GetInt32(0);
        //var title = reader.GetString(1);
        //var price = reader.GetDecimal(4).ToString();
        //Console.WriteLine($"{id} {title} {price}");
        //Console.WriteLine();

        //object[] cells = new object[reader.FieldCount];
        //reader.GetValues(cells);
        //string row = String.Join(",", cells);
        //Console.WriteLine(row);
        //for (int i = 0; i < columnsCount; i++)
        //    Console.WriteLine($"{reader[i]}; ");
        //Console.WriteLine($"{reader["Id"]} {reader["Title"]}");
        //if (reader["Description"] != DBNull.Value)
        //    Console.WriteLine($"Description {reader["Description"]}");
        //else
        //    Console.WriteLine("empty result");
        //Console.WriteLine();
    }

}

void TestSqlite()
{
    Console.WriteLine("SQLite");

    var fileName = Path.Combine(Environment.CurrentDirectory, "db31.sqlite");

    SqliteConnectionStringBuilder builder = new();
    builder.DataSource = fileName;
    string connectionString = builder.ConnectionString;

    connectionString = $"Data Source={fileName}";

    using SqliteConnection connection = new(connectionString);
    connection.Open();
}