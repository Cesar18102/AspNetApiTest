using AspNetBlankAppTest.Dto;
using AspNetBlankAppTest.Exceptions;
using AspNetBlankAppTest.Util.Validation.Patterns;

namespace AspNetBlankAppTest.Util.Validation
{
    public class SignUpFormValidator : FormValidator<UserSignUpFormDto>
    {
        protected override void ValidateForm(UserSignUpFormDto form)
        {
            if (!UserPatterns.PASSWORD_PATTERN.IsMatch(form.password))
                throw new InvalidPasswordException();

            if (!UserPatterns.LOGIN_PATTERN.IsMatch(form.login))
                throw new InvalidLoginException();
        }
    }
}