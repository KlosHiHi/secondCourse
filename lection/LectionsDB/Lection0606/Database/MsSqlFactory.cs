using Microsoft.Data.SqlClient;
using System.Data;

namespace Lection0606.Database
{
    public class MsSqlFactory(string connectionString) : IDataBaseFactory
    {
        public IDbConnection CreateConnection() => new SqlConnection(connectionString);
    }
}
