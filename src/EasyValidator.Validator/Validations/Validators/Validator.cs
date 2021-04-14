using EasyValidator.Validator.Errors;

namespace EasyValidator.Validator.Validations.Validators
{
    public abstract class Validator : Notify
    {
        protected Validator()
        {
            EasyValidatorContract = new EasyValidatorContract();
        }
        public EasyValidatorContract EasyValidatorContract { get; set; }
    }
}
