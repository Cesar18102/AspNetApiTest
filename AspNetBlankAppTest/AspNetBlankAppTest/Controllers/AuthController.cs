using System.Web.Http;
using System.Threading.Tasks;

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
                throw new InvalidDataException();

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
                throw new InvalidDataException();

            UserSession session =  await userService.LogIn(logInForm);
            WebApiApplication.DI.Resolve<SessionTable>().LogIn(session);

            return session;
        }

        public UserInfo LogOut([FromBody]UserSession session)
        {
            if (!ModelState.IsValid)
                throw new InvalidDataException();

            if (!WebApiApplication.DI.Resolve<SessionTable>().LogOut(session))
                throw new NotAutorizedException();

            return new UserInfo(session.id, session.login);
        }
    }
}
