using EasyValidator.Validator.Errors;

namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract<T> : Notify<Error>
    {
        public EasyValidatorContract<T> Requires()
        {
            return this;
        }

        public EasyValidatorContract<T> Concat(Notify<Error> notify)
        {
            if (!notify.Valid)
                AddErrors(notify.Errors);

            return this;
        }
    }
}
