using System.Collections.Generic;

namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract<T>
    {
        #region "decimal"

        /* decimal */

        
        public EasyValidatorContract<T> IsGreater(decimal val, decimal comparer, string message)
        {
            if (val <= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsGreaterOrEquals(decimal val, decimal comparer, string message)
        {
            if (val < comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsLower(decimal val, decimal comparer, string message)
        {
            if (val >= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsLowerOrEquals(decimal val, decimal comparer, string message)
        {
            if (val > comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> AreEquals(decimal val, decimal comparer, string message)
        {
            if (val != comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> AreNotEquals(decimal val, decimal comparer, string message)
        {
            if (val == comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsBetween(decimal val, decimal from, decimal to, string message)
        {
            if (!(val > from && val < to))
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

        #endregion

        #region "double"

        /* decimal */


        public EasyValidatorContract<T> IsGreater(double val, double comparer, string message)
        {
            if (val <= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsGreaterOrEquals(double val, double comparer, string message)
        {
            if (val < comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsLower(double val, double comparer, string message)
        {
            if (val >= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsLowerOrEquals(double val, double comparer, string message)
        {
            if (val > comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> AreEquals(double val, double comparer, string message)
        {
            if (val != comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> AreNotEquals(double val, double comparer, string message)
        {
            if (val == comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsBetween(double val, double from, double to, double message)
        {
            if (!(val > from && val < to))
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

        #endregion

        #region "int"

        /* decimal */


        public EasyValidatorContract<T> IsGreater(int val, int comparer, string message)
        {
            if (val <= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsGreaterOrEquals(int val, int comparer, string message)
        {
            if (val < comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsLower(int val, int comparer, string message)
        {
            if (val >= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsLowerOrEquals(int val, int comparer, string message)
        {
            if (val > comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> AreEquals(int val, int comparer, string message)
        {
            if (val != comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> AreNotEquals(int val, int comparer, string message)
        {
            if (val == comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsBetween(int val, int from, int to, string message)
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

        #endregion

        #region "float"

        /* decimal */


        public EasyValidatorContract<T> IsGreater(float val, float comparer, string message)
        {
            if (val <= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsGreaterOrEquals(float val, float comparer, string message)
        {
            if (val < comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsLower(float val, float comparer, string message)
        {
            if (val >= comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsLowerOrEquals(float val, float comparer, string message)
        {
            if (val > comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> AreEquals(float val, float comparer, string message)
        {
            if (val != comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> AreNotEquals(float val, float comparer, string message)
        {
            if (val == comparer)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsBetween(float val, float from, float to, string message)
        {
            if (!(val > from && val < to))
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> ContainsInList(float val, IList<float> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index < 0)
                AddError(message);

            return this;
        }


        public EasyValidatorContract<T> NotContainsInList(float val, IList<float> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index >= 0)
                AddError(message);

            return this;
        }

        #endregion
    }


}
