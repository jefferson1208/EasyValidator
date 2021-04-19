using System.Collections.Generic;

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

        public EasyValidatorContract<T> ContainsInList(int val, IList<int> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index < 0)
                AddError(message);

            return this;
        }


        public EasyValidatorContract<T> NotContainsInList(int val, IList<int> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index >= 0)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> ContainsInList(decimal val, IList<decimal> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index < 0)
                AddError(message);

            return this;
        }


        public EasyValidatorContract<T> NotContainsInList(decimal val, IList<decimal> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index >= 0)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> ContainsInList(double val, IList<double> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index < 0)
                AddError(message);

            return this;
        }


        public EasyValidatorContract<T> NotContainsInList(double val, IList<double> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index >= 0)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> OneOrAnother(dynamic priorityValue, dynamic secundaryValue, string message)
        {
            var value = priorityValue + secundaryValue;

            if (value <= 0)
                AddError(message);

            return this;
        }
    }
}
