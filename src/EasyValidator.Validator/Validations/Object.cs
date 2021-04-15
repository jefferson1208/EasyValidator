using System.Collections.Generic;

namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract<T>
    {
        public EasyValidatorContract<T> ContainsInList(T val, IList<T> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index < 0)
                AddError(message);

            return this;
        }


        public EasyValidatorContract<T> NotContainsInList(T val, IList<T> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index >= 0)
                AddError(message);

            return this;
        }
    }
}
