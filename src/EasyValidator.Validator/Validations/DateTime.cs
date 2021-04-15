using System;
namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract<T>
    {
        public EasyValidatorContract<T> IsGreater(DateTime val, DateTime comparer, string message)
        {
            if (val <= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsGreaterOrEquals(DateTime val, DateTime comparer, string message)
        {
            if (val < comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsLower(DateTime val, DateTime comparer, string message)
        {
            if (val >= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsLowerOrEquals(DateTime val, DateTime comparer, string message)
        {
            if (val > comparer)
                AddError(message);

            return this;
        }


        public EasyValidatorContract<T> IsBetween(DateTime val, DateTime from, DateTime to, string message)
        {
            if (!(val > from && val < to))
                AddError(message);

            return this;
        }


    }
}
