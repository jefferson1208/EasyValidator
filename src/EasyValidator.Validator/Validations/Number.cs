namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract
    {
        public EasyValidatorContract IsGreater(dynamic val, dynamic comparer, string message)
        {
            if ((double)val <= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsGreaterOrEquals(dynamic val, dynamic comparer, string message)
        {
            if ((double)val < comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsLower(dynamic val, dynamic comparer, string message)
        {
            if ((double)val >= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsLowerOrEquals(dynamic val, dynamic comparer, string message)
        {
            if ((double)val > comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract AreEquals(dynamic val, dynamic comparer, string message)
        {
            if (val != comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract AreNotEquals(dynamic val, dynamic comparer, string message)
        {
            if (val == comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsBetween(dynamic val, dynamic from, dynamic to, string message)
        {
            if (!(val > from && val < to))
                AddError(message);

            return this;
        }
    }
}
