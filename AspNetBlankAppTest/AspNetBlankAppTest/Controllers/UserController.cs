using System.Web.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

using Autofac;

using AspNetBlankAppTest.Models;
using AspNetBlankAppTest.Service;
using AspNetBlankAppTest.Repo.Util;

namespace AspNetBlankAppTest.Controllers
{
    public class UserController : ApiController
    {
        private static readonly UserService userService = new UserService(WebApiApplication.DI.Resolve<IRepoFactory>());

        public UserController() : base() { }

        [HttpGet]
        public async Task<IEnumerable<UserInfo>> GetUsers() => await userService.GetUsers();

        [HttpGet]
        public async Task<UserInfo> GetUserByLogin(string login) => await userService.GetUserByLogin(login);
    }
}
