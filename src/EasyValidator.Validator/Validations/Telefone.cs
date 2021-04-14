using System.Text.RegularExpressions;

namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract
    {
        public EasyValidatorContract IsPhone(string phone, string message)
        {
            var valid = Regex.IsMatch(phone, @"(\(?\d{2}\)?\s)?(\d{4,5}\-\d{4})");

            if (!valid)
                AddError(message);

            return this;
        }
    }
}
