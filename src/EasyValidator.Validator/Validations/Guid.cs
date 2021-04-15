using System;
using System.Text.RegularExpressions;

namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract<T>
    {
        public EasyValidatorContract<T> IsGuidNotEmpty(string guid, string message)
        {
            if (guid == Guid.Empty.ToString())
            {
                AddError(message);
                return this;
            }

            var valid =
                Regex.IsMatch(guid, @"(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}");

            if (!valid)
                AddError(message);

            return this;
        }
    }
}
