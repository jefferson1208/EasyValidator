namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract<T>
    {
        public EasyValidatorContract<T> IsGreater(dynamic val, dynamic comparer, string message)
        {
            if ((double)val <= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsGreaterOrEquals(dynamic val, dynamic comparer, string message)
        {
            if ((double)val < comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsLower(dynamic val, dynamic comparer, string message)
        {
            if ((double)val >= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsLowerOrEquals(dynamic val, dynamic comparer, string message)
        {
            if ((double)val > comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> AreEquals(dynamic val, dynamic comparer, string message)
        {
            if (val != comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> AreNotEquals(dynamic val, dynamic comparer, string message)
        {
            if (val == comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsBetween(dynamic val, dynamic from, dynamic to, string message)
        {
            if (!(val > from && val < to))
                AddError(message);

            return this;
        }
    }
}
