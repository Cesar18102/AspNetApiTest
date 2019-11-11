using System;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using MySql.Data.MySqlClient;

using AspNetBlankAppTest.Models;
using AspNetBlankAppTest.Repo.Impl;
using AspNetBlankAppTest.Repo.Util;
using AspNetBlankAppTest.Exceptions;
using System.Collections.Generic;

namespace AspNetBlankAppTest.Service
{
    public class UserService
    {
        private static readonly Regex DUPLICATE_LOGIN_EXCEPTION = new Regex("^Duplicate entry '\\w+' for key 'login'$");

        private UserRepo UserRepo { get; set; }
        public UserService(IRepoFactory repoFactory) => UserRepo = new UserRepo(repoFactory);

        public async Task SignUp(UserCredintails creds)
        {
            try { await UserRepo.Add(creds); }
            catch (Exception ex)
            {
                if (DUPLICATE_LOGIN_EXCEPTION.IsMatch(ex.Message))
                    throw new UserConflictException();
            }
        }

        public async Task<UserSession> LogIn(UserCredintails creds)
        {
            UserSession user = await UserRepo.LogIn(creds);

            if (user == null)
                throw new LogInFailedException();

            return user;
        }

        public async Task<IEnumerable<UserInfo>> GetUsers() => await UserRepo.GetAll();
        public async Task<UserInfo> GetUserById(int id) => await UserRepo.FindById(id);
        public async Task<UserInfo> GetUserByLogin(string login) => await UserRepo.FindByLogin(login);
    }
}