using System.Linq;
using System.Text.RegularExpressions;

namespace EasyValidator.Validator.Validations
{
    partial class EasyValidatorContract
    {
        public EasyValidatorContract IsCreditCard(string cardNumber, string message)
        {
            var checkSum = 0;
            cardNumber = Regex.Replace(cardNumber, @"[^0-9]+", "");

            if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length < 14)
            {
                AddError(message);
                return this;
            }

            for (int i = cardNumber.Length - 1; i >= 0; i -= 2)
                checkSum += (cardNumber[i] - '0');

            for (int i = cardNumber.Length - 2; i >= 0; i -= 2)
            {
                int val = ((cardNumber[i] - '0') * 2);
                while (val > 0)
                {
                    checkSum += (val % 10);
                    val /= 10;
                }
            }

            if (!((checkSum % 10) == 0))
                AddError(message);
            return this;
        }

    }
}