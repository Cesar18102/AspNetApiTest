using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using System.Collections.Generic;

using AspNetBlankAppTest.Models;
using AspNetBlankAppTest.Repo.Decl;
using AspNetBlankAppTest.Repo.Util;

namespace AspNetBlankAppTest.Repo.Impl
{
    public class UserRepo : IUserRepo
    {
        private const string USER_TABLE_NAME = "users";

        private const string LOGIN_PARAM_NAME = "@login";
        private const string SEED_PARAM_NAME = "@seed";
        private const string PWD_PARAM_NAME = "@pwd";

        private const string USER_LOGIN_TABLE_HEAD = "login";
        private const string USER_PWD_TABLE_HEAD = "pwd";
        private const string USER_ID_TABLE_HEAD = "id";

        private IDbCommandFactory CommandFactory { get; set; }
        private IDbConnection Connection { get; set; }

        public UserRepo(IDbCommandFactory commandFactory, IDbConnection connection)
        {
            this.CommandFactory = commandFactory;
            this.Connection = connection;
        }

        public async Task Add(UserCredintails credintails)
        {
            DbCommand cmd = CommandFactory.CreateCommand($"INSERT INTO {USER_TABLE_NAME} " +
                                                         $"VALUES(0, {LOGIN_PARAM_NAME}, {PWD_PARAM_NAME});", Connection);

            cmd.Parameters.Add(CommandFactory.CreateParameter(LOGIN_PARAM_NAME, credintails.Login));
            cmd.Parameters.Add(CommandFactory.CreateParameter(PWD_PARAM_NAME, credintails.PasswordEncoded));

            await cmd.ExecuteNonQueryAsync();
        }

        public async Task<UserInfo> LogIn(UserCredintails credintails)
        {
            DbCommand cmd = CommandFactory.CreateCommand($"SELECT {USER_ID_TABLE_HEAD}, {USER_LOGIN_TABLE_HEAD} " +
                                                         $"FROM {USER_TABLE_NAME} " +
                                                         $"WHERE {USER_LOGIN_TABLE_HEAD} = {LOGIN_PARAM_NAME} AND " +
                                                         $"UPPER(MD5(CONCAT({USER_PWD_TABLE_HEAD}, {SEED_PARAM_NAME}))) = UPPER({PWD_PARAM_NAME});", Connection);
            cmd.Parameters.Add(CommandFactory.CreateParameter(LOGIN_PARAM_NAME, credintails.Login));
            cmd.Parameters.Add(CommandFactory.CreateParameter(PWD_PARAM_NAME, credintails.PasswordEncoded));
            cmd.Parameters.Add(CommandFactory.CreateParameter(SEED_PARAM_NAME, credintails.Seed));

            return GetSingleRecord(await cmd.ExecuteReaderAsync());
        }

        public async Task<List<UserInfo>> GetAll()
        {
            using (DbDataReader dataReader = await CommandFactory.CreateCommand($"SELECT {USER_ID_TABLE_HEAD}, {USER_LOGIN_TABLE_HEAD} " +
                                                                                $"FROM {USER_TABLE_NAME} ", Connection).ExecuteReaderAsync())
            {
                List<UserInfo> users = new List<UserInfo>();

                while (dataReader.Read())
                    users.Add(new UserInfo((int)dataReader[USER_ID_TABLE_HEAD], dataReader[USER_LOGIN_TABLE_HEAD].ToString()));
                dataReader.Close();

                return users;
            }
        }

        public async Task<UserInfo> FindByLogin(string login)
        {
            DbCommand cmd = CommandFactory.CreateCommand($"SELECT {USER_ID_TABLE_HEAD}, {USER_LOGIN_TABLE_HEAD} " +
                                                         $"FROM {USER_TABLE_NAME} " +
                                                         $"WHERE {USER_LOGIN_TABLE_HEAD} = {LOGIN_PARAM_NAME};", Connection);
            cmd.Parameters.Add(CommandFactory.CreateParameter(LOGIN_PARAM_NAME, login));

            return GetSingleRecord(await cmd.ExecuteReaderAsync());
        }

        private static UserInfo GetSingleRecord(DbDataReader dataReader)
        {
            using (dataReader)
            {
                if (!dataReader.HasRows)
                    return null;

                dataReader.Read();
                UserInfo userInfo = new UserInfo((int)dataReader[USER_ID_TABLE_HEAD], dataReader[USER_LOGIN_TABLE_HEAD].ToString());
                dataReader.Close();

                return userInfo;
            }
        }
    }
}