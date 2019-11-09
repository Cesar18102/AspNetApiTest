using AspNetBlankAppTest.Dto;

namespace AspNetBlankAppTest.Models
{
    public class UserCredintails
    {
        public string Login { get; private set; }
        public string PasswordEncoded { get; private set; }
        public string Seed { get; private set; }

        public UserCredintails(string login, string pwdEncoded, string seed = "")
        {
            Login = login;
            PasswordEncoded = pwdEncoded;
            Seed = seed;
        }

        public static implicit operator UserCredintails(UserLogInFormDto logInForm) => new UserCredintails(logInForm.login, logInForm.passwordEncoded, logInForm.seed);
    }
}