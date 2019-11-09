using System.Data.Common;
using System.Threading.Tasks;
using System.Collections.Generic;

using AspNetBlankAppTest.Models;
using AspNetBlankAppTest.Repo.Decl;
using AspNetBlankAppTest.Repo.Util;
using System.Reflection;
using System;
using System.Linq;

namespace AspNetBlankAppTest.Repo.Impl
{
    public class UserRepo : Repo, IUserRepo
    {
        private const string USER_TABLE_NAME = "users";

        //private const string LOGIN_PARAM_NAME = "@login";
        private const string SEED_PARAM_NAME = "@seed";
        //private const string PWD_PARAM_NAME = "@pwd";

        private const string USER_ID_TABLE_HEAD = "id";
        private const string USER_LOGIN_TABLE_HEAD = "login";
        private const string USER_PWD_TABLE_HEAD = "pwd";
        private const string HASH_TABLE_HEAD = "hash";

        private static readonly Type USER_ID_TYPE = typeof(int);
        private static readonly Type USER_LOGIN_TYPE = typeof(string);
        //private static readonly Type USER_PWD_TYPE = typeof(string);
        private static readonly Type USER_HASH_TYPE = typeof(string);

        private IRepoFactory RepoFactory { get; set; }
        public UserRepo(IRepoFactory repoFactory) => RepoFactory = repoFactory;

        public async Task Add(UserCredintails credintails)
        {
            using (DbConnection connection = RepoFactory.GetConnection())
            {
                DbCommand cmd = RepoFactory.CreateCommand($"INSERT INTO {USER_TABLE_NAME} " +
                                                          $"VALUES(0, @{USER_LOGIN_TABLE_HEAD}, @{USER_PWD_TABLE_HEAD});", connection);

                cmd.Parameters.Add(RepoFactory.CreateParameter("@" + USER_LOGIN_TABLE_HEAD, credintails.login));
                cmd.Parameters.Add(RepoFactory.CreateParameter("@" + USER_PWD_TABLE_HEAD, credintails.passwordEncoded));

                await connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task<UserSession> LogIn(UserCredintails credintails)
        {
            using (DbConnection connection = RepoFactory.GetConnection())
            {
                DbCommand cmd = RepoFactory.CreateCommand($"SELECT {USER_ID_TABLE_HEAD}, {USER_LOGIN_TABLE_HEAD}, UPPER(MD5(CONCAT(login, pwd, RAND(), NOW()))) as {HASH_TABLE_HEAD} " +
                                                          $"FROM {USER_TABLE_NAME} " +
                                                          $"WHERE {USER_LOGIN_TABLE_HEAD} = @{USER_LOGIN_TABLE_HEAD} AND " +
                                                          $"UPPER(MD5(CONCAT({USER_PWD_TABLE_HEAD}, {SEED_PARAM_NAME}))) = UPPER(@{USER_PWD_TABLE_HEAD})", connection);

                cmd.Parameters.Add(RepoFactory.CreateParameter("@" + USER_LOGIN_TABLE_HEAD, credintails.login));
                cmd.Parameters.Add(RepoFactory.CreateParameter("@" + USER_PWD_TABLE_HEAD, credintails.passwordEncoded));
                cmd.Parameters.Add(RepoFactory.CreateParameter(SEED_PARAM_NAME, credintails.seed));

                await connection.OpenAsync();
                return (await GetRecords<UserSession>(cmd, (USER_ID_TYPE, USER_ID_TABLE_HEAD), 
                                                           (USER_LOGIN_TYPE, USER_LOGIN_TABLE_HEAD), 
                                                           (USER_HASH_TYPE, HASH_TABLE_HEAD)))
                                                           .FirstOrDefault();
            }
        }

        public async Task<IEnumerable<UserInfo>> GetAll()
        {
            using (DbConnection connection = RepoFactory.GetConnection())
            {
                DbCommand cmd = RepoFactory.CreateCommand($"SELECT {USER_ID_TABLE_HEAD}, {USER_LOGIN_TABLE_HEAD} " +
                                                          $"FROM {USER_TABLE_NAME} ", connection);

                await connection.OpenAsync();
                return (await GetRecords<UserInfo>(cmd, (USER_ID_TYPE, USER_ID_TABLE_HEAD), (USER_LOGIN_TYPE, USER_LOGIN_TABLE_HEAD))).ToList();
            }
        }

        public async Task<UserInfo> FindByLogin(string login)
        {
            using (DbConnection connection = RepoFactory.GetConnection())
            {
                DbCommand cmd = RepoFactory.CreateCommand($"SELECT {USER_ID_TABLE_HEAD}, {USER_LOGIN_TABLE_HEAD} " +
                                                          $"FROM {USER_TABLE_NAME} " +
                                                          $"WHERE {USER_LOGIN_TABLE_HEAD} = @{USER_LOGIN_TABLE_HEAD};", connection);

                cmd.Parameters.Add(RepoFactory.CreateParameter("@" + USER_LOGIN_TABLE_HEAD, login));

                await connection.OpenAsync();
                return (await GetRecords<UserInfo>(cmd, (USER_ID_TYPE, USER_ID_TABLE_HEAD), (USER_LOGIN_TYPE, USER_LOGIN_TABLE_HEAD))).FirstOrDefault();
            }
        }
    }
}