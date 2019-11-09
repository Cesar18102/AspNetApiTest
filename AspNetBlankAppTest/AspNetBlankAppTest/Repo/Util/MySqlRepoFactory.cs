using System;
using System.Data;
using System.Data.Common;

using MySql.Data.MySqlClient;

namespace AspNetBlankAppTest.Repo.Util
{
    public class MySqlRepoFactory : IRepoFactory
    {
        private const string CONNECTION_STRING = "Server=127.0.0.1; Database=test; Uid=root;";

        public DbConnection GetConnection() => new MySqlConnection(CONNECTION_STRING);

        public DbCommand CreateCommand(string cmdText, DbConnection connection)
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText = cmdText;
            return command;
        }

        public DbParameter CreateParameter(string name, object value) => new MySqlParameter(name, value);
    }
}