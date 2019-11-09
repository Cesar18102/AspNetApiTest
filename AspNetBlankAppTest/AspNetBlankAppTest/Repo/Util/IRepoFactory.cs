using System.Data.Common;

namespace AspNetBlankAppTest.Repo.Util
{
    public interface IRepoFactory
    {
        DbConnection GetConnection();
        DbCommand CreateCommand(string cmdText, DbConnection connection);
        DbParameter CreateParameter(string name, object value);
    }
}