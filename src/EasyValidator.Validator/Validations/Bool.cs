namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract<T>
    {
        public EasyValidatorContract<T> IsTrue(bool val, string message)
        {
            if (!val)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsFalse(bool val, string message)
        {
            if (val)
                AddError(message);

            return this;
        }
    }
}
