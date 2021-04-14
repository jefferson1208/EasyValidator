using System.Text.RegularExpressions;

namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract
    {
        public EasyValidatorContract IsCep(string cep, string message)
        {
            var valid = Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));

            if (!valid)
                AddError(message);

            return this;
        }
    }
}
