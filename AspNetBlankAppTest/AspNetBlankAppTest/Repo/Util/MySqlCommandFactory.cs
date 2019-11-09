using System;
using System.Data;
using System.Data.Common;

using MySql.Data.MySqlClient;

namespace AspNetBlankAppTest.Repo.Util
{
    public class MySqlCommandFactory : IDbCommandFactory
    {
        public DbCommand CreateCommand(string cmdText, IDbConnection mySqlConnection) => new MySqlCommand(cmdText, mySqlConnection as MySqlConnection);
        public DbParameter CreateParameter(string name, object value) => new MySqlParameter(name, value);
    }
}