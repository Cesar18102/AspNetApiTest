using System.Windows.Forms;
using AspNetBlankAppTest.Util.Validation.Patterns;

namespace TestAppClient.Util.Validation.Templates
{
    public class AuthFormValidator<T> : FormValidatorTemplate<T> where T : Control
    {
        public AuthFormValidator(T loginInput, T passwordInput) : base()
        {
            FieldValidationHandler<T> loginValidation =
                new FieldValidationHandler<T>(input => AuthFormPatterns.LOGIN_PATTERN.IsMatch(input.Text), OnInvalid, OnValid);

            FieldValidationHandler<T> passwordValidation =
                new FieldValidationHandler<T>(input => AuthFormPatterns.PASSWORD_PATTERN.IsMatch(input.Text), OnInvalid, OnValid);

            Add(loginValidation, loginInput, OnChangedEventValidationBind);
            Add(passwordValidation, passwordInput, OnChangedEventValidationBind);
        }
    }
}
