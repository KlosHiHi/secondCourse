// Task 1
Console.WriteLine($"MSSQL: {MsSqlLibrary.DataAccessLayer.ConnectionString}");
Console.WriteLine($"SQLite: {SqliteLibrary.DataAccessLayer.ConnectionString}");

// Task 2
Console.Write("Введите запрос SELECT (mssql): ");
string msSqlQuery = Console.ReadLine();

Console.Write("Введите запрос SELECT (sqlite): ");
string sqliteQuery = Console.ReadLine();

Console.WriteLine($"MSSQL: {MsSqlLibrary.DataAccessLayer.GetScalarValue(msSqlQuery)}");
Console.WriteLine($"SQLite: {SqliteLibrary.DataAccessLayer.GetScalarValue(sqliteQuery)}");

// Task 3
try
{
    MsSqlLibrary.DataAccessLayer.UpdateGamesData();
    Console.WriteLine("[MSSQL Games]");
    foreach (MsSqlLibrary.Game item in MsSqlLibrary.DataAccessLayer.Games)
        Console.WriteLine(item);
}
catch
{
    Console.WriteLine("Ошибка подключения к MSSQL");
}

try
{
    SqliteLibrary.DataAccessLayer.UpdateGamesData();
    Console.WriteLine("[SQLite Games]");
    foreach (SqliteLibrary.Game item in SqliteLibrary.DataAccessLayer.Games)
        Console.WriteLine(item);
}
catch
{
    Console.WriteLine("Ошибка подключения к SQLite");
}

// Task 4
try
{
    var msSqlTable = MsSqlLibrary.DataAccessLayer.GetData("SELECT * FROM Games", "games");
}
catch
{
    Console.WriteLine("Ошибка подключения к MSSQL");
}

try
{
    var sqliteTable = SqliteLibrary.DataAccessLayer.GetData("SELECT * FROM Games", "games");
}
catch
{
    Console.WriteLine("Ошибка подключения к SQLite");
}