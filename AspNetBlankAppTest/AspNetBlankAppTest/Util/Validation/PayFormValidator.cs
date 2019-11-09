using AspNetBlankAppTest.Dto;
using AspNetBlankAppTest.Exceptions;
using AspNetBlankAppTest.Util.Validation.Patterns;

namespace AspNetBlankAppTest.Util.Validation
{
    public class PayFormValidator : FormValidator<PaymentFormDto>
    {
        protected override void ValidateForm(PaymentFormDto form)
        {
            if (!PayPatterns.FIRST_NAME_PATTERN.IsMatch(form.firstName) ||
                !PayPatterns.LAST_NAME_PATTERN.IsMatch(form.lastName) ||
                (form.patronymic != null && !PayPatterns.PATRONYMIC_PATTERN.IsMatch(form.patronymic)))
                throw new InvalidDataException();
        }
    }
}