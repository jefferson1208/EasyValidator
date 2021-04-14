
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract
    {
        public EasyValidatorContract IsNotNullOrEmpty(string val, string message)
        {
            if (string.IsNullOrEmpty(val))
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsNullOrEmpty(string val, string message)
        {
            if (!string.IsNullOrEmpty(val))
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsNullOrWhiteSpace(string val, string message)
        {
            if (!string.IsNullOrWhiteSpace(val))
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsNotNullOrWhiteSpace(string val, string message)
        {
            if (string.IsNullOrWhiteSpace(val))
                AddError(message);

            return this;
        }

        public EasyValidatorContract HasMinimumLength(string val, int min, string message)
        {
            if ((val ?? "").Length < min)
                AddError(message);

            return this;
        }

        public EasyValidatorContract HasMaximumLength(string val, int max, string message)
        {
            if ((val ?? "").Length > max)
                AddError(message);

            return this;
        }

        public EasyValidatorContract HasLength(string val, int len, string message)
        {
            if ((val ?? "").Length != len)
                AddError(message);

            return this;
        }

        public EasyValidatorContract Contains(string val, string comparer, string message)
        {
            if (!val.Contains(comparer))
                AddError(message);

            return this;
        }

        public EasyValidatorContract NotContains(string val, string comparer, string message)
        {
            if (val.Contains(comparer))
                AddError(message);

            return this;
        }

        public EasyValidatorContract ContainsInList(string val, List<string> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index < 0)
                AddError(message);

            return this;
        }

        public EasyValidatorContract NotContainsInList(string val, List<string> comparer, string message)
        {
            var index = comparer.IndexOf(val);

            if (index >= 0)
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsNotEmail(string val, string message)
        {
            var valid = Regex.IsMatch(val, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (valid)
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsEmail(string val, string message)
        {
            var valid =  Regex.IsMatch(val, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (!valid)
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsUrl(string val, string message)
        {
            var valid = Regex.IsMatch(val, 
                @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$");

            if (!valid)
                AddError(message);

            return this;
        }

        public EasyValidatorContract IsNotUrl(string val, string message)
        {
            var valid = Regex.IsMatch(val,
                @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$");

            if (valid)
                AddError(message);

            return this;
        }
    }
}
