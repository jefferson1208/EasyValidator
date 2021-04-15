using System.Text.RegularExpressions;
namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract<T>
    {
        public EasyValidatorContract<T> IsCep(string cep, string message)
        {
            if (string.IsNullOrEmpty(cep))
            {
                AddError(message);
                return this;
            }

            var valid = Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));

            if (!valid)
                AddError(message);

            return this;
        }
    }
}
