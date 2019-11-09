using System.Data;
using System.Data.Common;

namespace AspNetBlankAppTest.Repo.Util
{
    public interface IDbCommandFactory
    {
        DbCommand CreateCommand(string cmdText, IDbConnection connection);
        DbParameter CreateParameter(string name, object value);
    }
}
