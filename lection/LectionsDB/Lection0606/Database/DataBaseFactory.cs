using System.Data;

namespace Lection0606.Database
{
    public interface IDataBaseFactory
    {
        IDbConnection CreateConnection();
    }
}
