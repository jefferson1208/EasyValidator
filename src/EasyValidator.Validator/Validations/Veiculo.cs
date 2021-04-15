using System.Text.RegularExpressions;

namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract<T>
    {

        public EasyValidatorContract<T> CarLicensePlate(string license, string message)
        {
            var valid = Regex.IsMatch(license, ("[a-zA-Z]{3}[0-9]{4}")) && license.Length == 7;

            if (!valid)
                AddError(message);

            return this;
        }

        public EasyValidatorContract<T> CarLicensePlateMercosul(string license, string message)
        {
            var valid = Regex.IsMatch(license, ("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}")) && license.Length == 7;

            if (!valid)
                AddError(message);

            return this;
        }
    }
}
