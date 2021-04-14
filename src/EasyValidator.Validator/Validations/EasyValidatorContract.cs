using EasyValidator.Validator.Errors;

namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract : Notify
    {
        public EasyValidatorContract Requires()
        {
            return this;
        }

        public EasyValidatorContract Concat(Notify notify)
        {
            if (notify.Invalid)
                AddErrors(notify.Errors);

            return this;
        }
    }
}
