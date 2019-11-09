using System.Web.Http;
using System.Data.Common;
using System.Threading.Tasks;
using System.Collections.Generic;

using MySql.Data.MySqlClient;

using AspNetBlankAppTest.Dto;
using AspNetBlankAppTest.Models;
using AspNetBlankAppTest.Service;
using AspNetBlankAppTest.Repo.Util;
using AspNetBlankAppTest.Util.Validation;
using AspNetBlankAppTest.Util.Encryption;

namespace AspNetBlankAppTest.Controllers
{
    public class AuthController : ApiController
    {
        private static readonly IDbCommandFactory commandFactory = new MySqlCommandFactory();
        private static readonly DbConnection connection = new MySqlConnection("Server=127.0.0.1; Database=test; Uid=root;");
        private static readonly UserService userService = new UserService(commandFactory, connection);

        private static readonly SignUpFormValidator signUpValidator = new SignUpFormValidator();

        static AuthController() => connection.Open();

        public AuthController() : base() { }

        [HttpPost]
        public async Task<UserInfo> SignUp([FromBody]UserSignUpFormDto signUpForm)//check if password encoded, validate
        {
            signUpValidator.Validate(signUpForm);
            return await userService.SignUp(new UserCredintails(signUpForm.login, PasswordEncrypter.Encrypt(signUpForm.password)));
        }

        [HttpPost]
        public async Task<UserInfo> LogIn([FromBody]UserLogInFormDto logInForm) // change exceptions
        {
            return await userService.LogIn(logInForm);
        }

        [HttpGet]
        public async Task<IEnumerable<UserInfo>> GetUsers() => await userService.GetUsers();

        [HttpGet]
        public async Task<UserInfo> GetUserByLogin(string login) => await userService.GetUserByLogin(login);
    }
}
