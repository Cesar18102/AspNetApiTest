using System;
using System.Data.Common;
using System.Threading.Tasks;
using System.Collections.Generic;

using AspNetBlankAppTest.Models;
using AspNetBlankAppTest.Repo.Decl;
using AspNetBlankAppTest.Repo.Util;

namespace AspNetBlankAppTest.Repo.Impl
{
    public class PayRepo : Repo, IPayRepo
    {
        private const string PAY_TABLE_NAME = "pay";
        private const string USERS_TABLE_NAME = "users";

        private const string USER_ID_ORIGIN_TABLE_HEAD = "id";
        private const string USER_LOGIN_ORIGIN_TABLE_HEAD = "login";

        private const string USER_ID_TABLE_HEAD = "user_id";
        private const string FIRST_NAME_TABLE_HEAD = "firstName";
        private const string LAST_NAME_TABLE_HEAD = "lastName";
        private const string PATRONYMIC_TABLE_HEAD = "patronymic";
        private const string AMOUNT_TABLE_HEAD = "amount";
        private const string PAY_DATE_TABLE_HEAD = "payDate";
        private const string PAYED_TABLE_HEAD = "payed";

        private static readonly Type USER_ID_TYPE = typeof(int);
        private static readonly Type USER_LOGIN_TYPE = typeof(string);
        private static readonly Type FIRST_NAME_TYPE = typeof(string);
        private static readonly Type LAST_NAME_TYPE = typeof(string);
        private static readonly Type PATRONYMIC_TYPE = typeof(string);
        private static readonly Type AMOUNT_TYPE = typeof(double);
        private static readonly Type PAY_DATE_TYPE = typeof(DateTime);
        private static readonly Type PAYED_TYPE = typeof(bool);

        private IRepoFactory RepoFactory { get; set; }
        public PayRepo(IRepoFactory repoFactory) => RepoFactory = repoFactory;

        public async Task Add(PaymentInfo paymentInfo)
        {
            using (DbConnection connection = RepoFactory.GetConnection())
            {
                DbCommand cmd = RepoFactory.CreateCommand($"INSERT INTO {PAY_TABLE_NAME} " +
                                                          $"VALUES(0, @{USER_ID_TABLE_HEAD}, @{FIRST_NAME_TABLE_HEAD}, @{LAST_NAME_TABLE_HEAD}, " +
                                                          $"@{PATRONYMIC_TABLE_HEAD}, @{AMOUNT_TABLE_HEAD}, @{PAY_DATE_TABLE_HEAD}, @{PAYED_TABLE_HEAD})", connection);

                cmd.Parameters.Add(RepoFactory.CreateParameter("@" + USER_ID_TABLE_HEAD, paymentInfo.creator.id));
                cmd.Parameters.Add(RepoFactory.CreateParameter("@" + FIRST_NAME_TABLE_HEAD, paymentInfo.firstName));
                cmd.Parameters.Add(RepoFactory.CreateParameter("@" + LAST_NAME_TABLE_HEAD, paymentInfo.lastName));
                cmd.Parameters.Add(RepoFactory.CreateParameter("@" + PATRONYMIC_TABLE_HEAD, paymentInfo.patronymic));
                cmd.Parameters.Add(RepoFactory.CreateParameter("@" + AMOUNT_TABLE_HEAD, paymentInfo.amount));
                cmd.Parameters.Add(RepoFactory.CreateParameter("@" + PAY_DATE_TABLE_HEAD, paymentInfo.payDate));
                cmd.Parameters.Add(RepoFactory.CreateParameter("@" + PAYED_TABLE_HEAD, paymentInfo.payed));

                await connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task<IEnumerable<PaymentInfo>> Get(int id = -1)
        {
            using(DbConnection connection = RepoFactory.GetConnection())
            {
                DbCommand cmd = RepoFactory.CreateCommand($"SELECT U.{USER_ID_ORIGIN_TABLE_HEAD}, U.{USER_LOGIN_ORIGIN_TABLE_HEAD}, P.* " +
                                                          $"FROM {PAY_TABLE_NAME} P JOIN {USERS_TABLE_NAME} U " +
                                                          $"ON P.{USER_ID_TABLE_HEAD} = U.{USER_ID_ORIGIN_TABLE_HEAD}" + 
                                                          (id == -1 ? "" : $" WHERE {USER_ID_TABLE_HEAD} = {id}"), connection);

                await connection.OpenAsync();
                return await GetRecords<PaymentInfo>(cmd, (USER_ID_TYPE, USER_ID_ORIGIN_TABLE_HEAD),
                                                          (USER_LOGIN_TYPE, USER_LOGIN_ORIGIN_TABLE_HEAD),
                                                          (FIRST_NAME_TYPE, FIRST_NAME_TABLE_HEAD),
                                                          (LAST_NAME_TYPE, LAST_NAME_TABLE_HEAD),
                                                          (PATRONYMIC_TYPE, PATRONYMIC_TABLE_HEAD),
                                                          (AMOUNT_TYPE, AMOUNT_TABLE_HEAD),
                                                          (PAY_DATE_TYPE, PAY_DATE_TABLE_HEAD),
                                                          (PAYED_TYPE, PAYED_TABLE_HEAD));
            }
        }
    }
}