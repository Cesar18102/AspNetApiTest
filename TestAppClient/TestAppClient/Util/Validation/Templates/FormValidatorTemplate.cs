using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestAppClient.Util.Validation.Templates
{
    public abstract class FormValidatorTemplate<T> : FormValidator where T : Control
    {
        protected ValidationHandler<T> OnValid = input => input.BackColor = Color.FromKnownColor(KnownColor.Window);
        protected ValidationHandler<T> OnInvalid = input => input.BackColor = Color.IndianRed;

        protected Callback<T> OnChangedEventValidationBind { get; private set; }

        public FormValidatorTemplate() : base() =>
            OnChangedEventValidationBind = input =>
            {
                input.LostFocus += (sender, e) => ValidateId(GetId<T>(input));
                input.TextChanged += (sender, e) => ValidateId(GetId<T>(input));
            };
    }
}
