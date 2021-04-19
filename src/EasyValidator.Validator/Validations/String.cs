using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract<T>
    {
        public EasyValidatorContract<T> IsNotNullOrEmpty(string val, string message)
        {
            if (string.IsNullOrEmpty(val))
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsNullOrEmpty(string val, string message)
        {
            if (!string.IsNullOrEmpty(val))
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsNullOrWhiteSpace(string val, string message)
        {
            if (!string.IsNullOrWhiteSpace(val))
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsNotNullOrWhiteSpace(string val, string message)
        {
            if (string.IsNullOrWhiteSpace(val))
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> HasMinimumLength(string val, int min, string message)
        {
            if ((val ?? "").Length < min)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> HasMaximumLength(string val, int max, string message)
        {
            if ((val ?? "").Length > max)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> HasLength(string val, int len, string message)
        {
            if ((val ?? "").Length != len)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> Contains(string val, string comparer, string message)
        {
            if (!val.Contains(comparer))
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> NotContains(string val, string comparer, string message)
        {
            if (val.Contains(comparer))
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> ContainsInList(string val, IList<string> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index < 0)
                AddError(message);

            return this;
        }


        public EasyValidatorContract<T> NotContainsInList(string val, IList<string> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index >= 0)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsNotEmail(string val, string message)
        {
            var valid = Regex.IsMatch(val, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (valid)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsEmail(string val, string message)
        {
            var valid = Regex.IsMatch(val, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (!valid)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsUrl(string val, string message)
        {
            var valid = Regex.IsMatch(val,
                @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$");

            if (!valid)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> IsNotUrl(string val, string message)
        {
            var valid = Regex.IsMatch(val,
                @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$");

            if (valid)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> OneOrAnother(string priorityValue, string secundaryValue, string message)
        {
            if (string.IsNullOrEmpty(priorityValue) && string.IsNullOrEmpty(secundaryValue))
            {
                AddError(message);
                return this;
            }

            var value = priorityValue.Length + secundaryValue.Length;

            if (value <= 0)
                AddError(message);

            return this;
        }
    }
}
