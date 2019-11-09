﻿using System.Data;
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
        public UserService(IDbCommandFactory commandFactory, IDbConnection connection) => UserRepo = new UserRepo(commandFactory, connection);

        public async Task<UserInfo> SignUp(UserCredintails creds)
        {
            try { await UserRepo.Add(creds); }
            catch (MySqlException ex)
            {
                if (DUPLICATE_LOGIN_EXCEPTION.IsMatch(ex.Message))
                    throw new UserConflictException();
            }

            return await UserRepo.FindByLogin(creds.Login);
        }

        public async Task<UserInfo> LogIn(UserCredintails creds)
        {
            UserInfo user = await UserRepo.LogIn(creds);

            if (user == null)
                throw new LogInFailedException();

            return user;
        }

        public async Task<IEnumerable<UserInfo>> GetUsers() => await UserRepo.GetAll();
        public async Task<UserInfo> GetUserByLogin(string login) => await UserRepo.FindByLogin(login);
    }
}