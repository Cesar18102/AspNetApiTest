using AspNetBlankAppTest.Dto;

namespace AspNetBlankAppTest.Util.Validation
{
    public abstract class FormValidator<T> where T : IForm
    {
        protected abstract void ValidateForm(T form);
        public void Validate(T form) => ValidateForm(form);
    }
}