using Microsoft.Data.Sqlite;
using System.Data;

namespace Lection0606.Database
{
    public class SqliteFactory(string connectionString) : IDataBaseFactory
    {
        public IDbConnection CreateConnection() => new SqliteConnection(connectionString);
    }
}
