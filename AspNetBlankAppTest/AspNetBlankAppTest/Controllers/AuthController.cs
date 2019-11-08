using System;
using System.Web.Http;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using MySql.Data.MySqlClient;

using AspNetBlankAppTest.Models;

namespace AspNetBlankAppTest.Controllers
{
    public class AuthController : ApiController
    {
        private const string USER_TABLE_NAME = "users";

        private const string LOGIN_PARAM_NAME = "@login";
        private const string PWD_PARAM_NAME = "@pwd";
        private const string ID_PARAM_NAME = "@id";

        private const string USER_LOGIN_TABLE_HEAD = "login";
        private const string USER_PWD_TABLE_HEAD = "pwd";
        private const string USER_ID_TABLE_HEAD = "id";

        private class DuplicateLoginException : Exception { }
        private static readonly Regex DUPLICATE_LOGIN_EXCEPTION = new Regex("^Duplicate entry '\\w+' for key 'login'$");

        private class NoSuchUserException : Exception { }

        private static readonly MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; Database=test; Uid=root;");
        static AuthController() => connection.Open();

        public AuthController() : base() { }

        [HttpPost]
        public UserInfo SignUp([FromBody]UserCredintails creds)//check if password encoded, validate
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO {USER_TABLE_NAME} " +
                                                    $"VALUES(0, {LOGIN_PARAM_NAME}, {PWD_PARAM_NAME});", connection);
            command.Parameters.Add(new MySqlParameter(LOGIN_PARAM_NAME, creds.login));
            command.Parameters.Add(new MySqlParameter(PWD_PARAM_NAME, creds.passwordEncoded));

            try
            {
                command.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                if (DUPLICATE_LOGIN_EXCEPTION.IsMatch(ex.Message))
                    throw new DuplicateLoginException();
            }

            return GetUserByLogin(creds.login);
        }

        [HttpPost]
        public UserInfo LogIn([FromBody]UserCredintails credintails) // change exceptions
        {
            MySqlCommand command = new MySqlCommand($"SELECT {USER_ID_TABLE_HEAD}, {USER_LOGIN_TABLE_HEAD} " +
                                                    $"FROM {USER_TABLE_NAME} " +
                                                    $"WHERE {USER_LOGIN_TABLE_HEAD} = {LOGIN_PARAM_NAME} AND {USER_PWD_TABLE_HEAD} = {PWD_PARAM_NAME};", connection);
            command.Parameters.Add(new MySqlParameter(LOGIN_PARAM_NAME, credintails.login));
            command.Parameters.Add(new MySqlParameter(PWD_PARAM_NAME, credintails.passwordEncoded));

            MySqlDataReader dataReader = command.ExecuteReader();

            if (!dataReader.HasRows)
                throw new NoSuchUserException();

            dataReader.Read();
            UserInfo userInfo = new UserInfo((int)dataReader[USER_ID_TABLE_HEAD], dataReader[USER_LOGIN_TABLE_HEAD].ToString());
            dataReader.Close();

            return userInfo;
        }

        [HttpGet]
        public IEnumerable<UserInfo> GetUsers()
        {
            MySqlDataReader dataReader = new MySqlCommand($"SELECT {USER_ID_TABLE_HEAD}, {USER_LOGIN_TABLE_HEAD} " +
                                                          $"FROM {USER_TABLE_NAME};", connection).ExecuteReader();
            List<UserInfo> users = new List<UserInfo>();

            while(dataReader.Read())
                users.Add(new UserInfo((int)dataReader[USER_ID_TABLE_HEAD], dataReader[USER_LOGIN_TABLE_HEAD].ToString()));

            dataReader.Close();
            return users;
        }

        [HttpGet]
        public UserInfo GetUserByLogin(string login)
        {
            MySqlCommand command = new MySqlCommand($"SELECT {USER_ID_TABLE_HEAD}, {USER_LOGIN_TABLE_HEAD} " +
                                                    $"FROM {USER_TABLE_NAME} " +
                                                    $"WHERE {USER_LOGIN_TABLE_HEAD} = {LOGIN_PARAM_NAME};", connection);
            command.Parameters.Add(new MySqlParameter(LOGIN_PARAM_NAME, login));

            MySqlDataReader dataReader = command.ExecuteReader();

            if (!dataReader.HasRows)
                throw new NoSuchUserException();

            dataReader.Read();
            UserInfo userInfo = new UserInfo((int)dataReader[USER_ID_TABLE_HEAD], dataReader[USER_LOGIN_TABLE_HEAD].ToString());
            dataReader.Close();

            return userInfo;
        }
    }
}
