using System.Net;
using System.Web.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

using Autofac;

using AspNetBlankAppTest.Dto;
using AspNetBlankAppTest.Models;
using AspNetBlankAppTest.Service;
using AspNetBlankAppTest.Repo.Util;
using AspNetBlankAppTest.Util.Validation;
using AspNetBlankAppTest.Util.Encryption;
using AspNetBlankAppTest.Exceptions;

namespace AspNetBlankAppTest.Controllers
{
    public class AuthController : ApiController
    {
        private static readonly FormValidator<UserSignUpFormDto> signUpValidator = new SignUpFormValidator();
        private static readonly UserService userService = new UserService(WebApiApplication.DI.Resolve<IRepoFactory>());

        public AuthController() : base() { }

        [HttpPost]
        public async Task<UserSession> SignUp([FromBody]UserSignUpFormDto signUpForm)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            signUpValidator.Validate(signUpForm);

            UserCredintails signUpCredintails = new UserCredintails(signUpForm.login, Encryptor.Encrypt(signUpForm.password));
            await userService.SignUp(signUpCredintails);

            UserCredintails logInCredintails = new UserCredintails(signUpCredintails.login, Encryptor.Encrypt(signUpCredintails.passwordEncoded));
            UserSession session = await userService.LogIn(logInCredintails);

            WebApiApplication.DI.Resolve<SessionTable>().LogIn(session);
            return session;
        }

        [HttpPost]
        public async Task<UserSession> LogIn([FromBody]UserLogInFormDto logInForm)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            UserSession session =  await userService.LogIn(logInForm);
            WebApiApplication.DI.Resolve<SessionTable>().LogIn(session);

            return session;
        }

        //public IEnumerable<UserSession> GetSessions() => WebApiApplication.DI.Resolve<SessionTable>().GetSessions();//remove
    }
}
