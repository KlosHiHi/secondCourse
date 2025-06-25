using Microsoft.Data.SqlClient;

CreateDatabase();


static void CreateDatabase()
{
        string connectionString = GetConnetionString();
        using SqlConnection connection = new(connectionString);
        connection.Open();

        string createQuery = "CREATE TABLE Role (Id INT IDENTITY(1,1) PRIMARY KEY, Name NVARCHAR(30) NOT NULL);";
        SqlCommand command = new(createQuery, connection);
        command.ExecuteNonQuery();

        createQuery = "CREATE TABLE [User] (Id INTEGER IDENTITY(1,1) PRIMARY KEY, RoleId INT NOT NULL, Login NVARCHAR(50) NOT NULL, Password NVARCHAR(30) NOT NULL, FOREIGN KEY (RoleId) REFERENCES Role(Id));";
        command = new(createQuery, connection);
        command.ExecuteNonQuery();

        Console.WriteLine("Создание прошло успешно");

}

static string GetConnetionString()
{
    Console.WriteLine("Microsoft SQL Server");

    SqlConnectionStringBuilder builder = new()
    {
        DataSource = "mssql",
        InitialCatalog = "ispp3101",
        UserID = "ispp3101",
        Password = "3101",
        TrustServerCertificate = true
    };
    string connectionString = builder.ConnectionString;

    return connectionString;
}