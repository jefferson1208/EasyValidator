using System;

namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract
    {
        public EasyValidatorContract IsGreater(DateTime val, DateTime comparer, string message)
        {
            if (val <= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsGreaterOrEquals(DateTime val, DateTime comparer, string message)
        {
            if (val < comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsLower(DateTime val, DateTime comparer, string message)
        {
            if (val >= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsLowerOrEquals(DateTime val, DateTime comparer, string message)
        {
            if (val > comparer)
                AddError(message);

            return this;
        }


        public EasyValidatorContract IsBetween(DateTime val, DateTime from, DateTime to, string message)
        {
            if (!(val > from && val < to))
                AddError(message);

            return this;
        }


    }
}
