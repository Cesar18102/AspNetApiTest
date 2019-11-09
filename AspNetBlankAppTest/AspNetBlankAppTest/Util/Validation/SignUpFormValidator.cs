using AspNetBlankAppTest.Dto;
using AspNetBlankAppTest.Exceptions;
using AspNetBlankAppTest.Util.Validation.Patterns;

namespace AspNetBlankAppTest.Util.Validation
{
    public class SignUpFormValidator
    {
        public void Validate(UserSignUpFormDto signUpForm)
        {
            if (!UserPatterns.PASSWORD_PATTERN.IsMatch(signUpForm.password))
                throw new InvalidPasswordException();

            if (!UserPatterns.LOGIN_PATTERN.IsMatch(signUpForm.login))
                throw new InvalidLoginException();
        }
    }
}