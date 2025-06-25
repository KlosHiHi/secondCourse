using Microsoft.Data.Sqlite;

CreateDatabase("TestDB.sqlite");

static void CreateDatabase(string dataBase)
{
    try
    {
        SqliteConnection connection = GetSqliteConnection(dataBase);
        connection.Open();

        string createQuery = "CREATE TABLE Game (Id INTEGER PRIMARY KEY AUTOINCREMENT, Title TEXT NOT NULL, Description TEXT NULL, PublicationYear INTEGER NOT NULL, Price REAL NOT NULL);";
        SqliteCommand command = new(createQuery, connection);
        command.ExecuteNonQuery();

        createQuery = "CREATE TABLE Review ( Id INTEGER PRIMARY KEY AUTOINCREMENT, GameId INTEGER NOT NULL, User TEXT NOT NULL, Comment TEXT NOT NULL, PublicationDate TEXT NOT NULL, FOREIGN KEY (GameId) REFERENCES Game(Id));";
        command = new(createQuery, connection);
        command.ExecuteNonQuery();

        Console.WriteLine("Создание базы данных прошло успешно");

        connection.Close();
    }
    catch
    {
        Console.WriteLine("Такая база данных уже существует");
    }
}

static SqliteConnection GetSqliteConnection(string dbName)
{
    Console.WriteLine("SQLite");

    var fileName = Path.Combine(Environment.CurrentDirectory, dbName);

    string connectionString = $"Data Source={fileName}";

    using SqliteConnection connection = new(connectionString);
    return connection;
}