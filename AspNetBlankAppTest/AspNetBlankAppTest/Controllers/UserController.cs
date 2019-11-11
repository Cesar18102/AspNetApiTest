using System.Web.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

using Autofac;

using AspNetBlankAppTest.Models;
using AspNetBlankAppTest.Service;
using AspNetBlankAppTest.Repo.Util;
using AspNetBlankAppTest.Exceptions;

namespace AspNetBlankAppTest.Controllers
{
    public class UserController : ApiController
    {
        private static readonly UserService userService = new UserService(WebApiApplication.DI.Resolve<IRepoFactory>());

        public UserController() : base() { }

        [HttpGet]
        public async Task<IEnumerable<UserInfo>> GetAll() => await userService.GetUsers();

        [HttpGet]
        public async Task<UserInfo> GetByLogin(string login)
        {
            UserInfo user = await userService.GetUserByLogin(login);

            if (user == null)
                throw new NoSuchUserException();

            return user;
        }

        [HttpGet]
        public async Task<UserInfo> GetById(int id)
        {
            UserInfo user = await userService.GetUserById(id);

            if (user == null)
                throw new NoSuchUserException();

            return user;
        }
    }
}
