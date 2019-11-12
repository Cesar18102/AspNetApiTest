using System.Windows.Forms;

using AspNetBlankAppTest.Util.Validation.Patterns;

namespace TestAppClient.Util.Validation.Templates
{
    public class PaymentFormValidator<T> : FormValidatorTemplate<T> where T : Control
    {
        public PaymentFormValidator(T firstNameInput, T lastNameInput, T patronymicInput)
        {
            FieldValidationHandler<T> firstNameValidation =
                new FieldValidationHandler<T>(input => PaymentFormPatterns.FIRST_NAME_PATTERN.IsMatch(firstNameInput.Text), OnInvalid, OnValid);

            FieldValidationHandler<T> lastNameValidation =
                new FieldValidationHandler<T>(input => PaymentFormPatterns.LAST_NAME_PATTERN.IsMatch(lastNameInput.Text), OnInvalid, OnValid);

            FieldValidationHandler<T> patronymicValidation =
                new FieldValidationHandler<T>(input => patronymicInput.Text == null || 
                                                       PaymentFormPatterns.PATRONYMIC_PATTERN.IsMatch(patronymicInput.Text), OnInvalid, OnValid);

            Add(firstNameValidation, firstNameInput, OnChangedEventValidationBind);
            Add(lastNameValidation, lastNameInput, OnChangedEventValidationBind);
            Add(patronymicValidation, patronymicInput, OnChangedEventValidationBind);
        }
    }
}
