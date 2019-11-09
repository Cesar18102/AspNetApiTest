using AspNetBlankAppTest.Dto;

namespace AspNetBlankAppTest.Models
{
    public class UserCredintails
    {
        public string login { get; private set; }
        public string passwordEncoded { get; private set; }
        public string seed { get; private set; }

        public UserCredintails(string login, string pwdEncoded, string seed = "")
        {
            this.login = login;
            this.passwordEncoded = pwdEncoded;
            this.seed = seed;
        }

        public static implicit operator UserCredintails(UserLogInFormDto logInForm) => new UserCredintails(logInForm.login, logInForm.passwordEncoded, logInForm.seed);
    }
}