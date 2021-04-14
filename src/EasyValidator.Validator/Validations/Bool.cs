namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract
    {
        public EasyValidatorContract IsTrue(bool val, string message)
        {
            if (!val)
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsFalse(bool val, string message)
        {
            if (val)
                AddError(message);

            return this;
        }
    }
}
