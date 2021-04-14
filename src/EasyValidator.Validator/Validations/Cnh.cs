using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EasyValidator.Validator.Validations
{
    public partial class EasyValidatorContract
    {
        public EasyValidatorContract IsCnh(string value, string message)
        {
            var isValid = false;
            value = Regex.Replace(value, @"[^0-9]+", "");

            if (value.Length == 11 && value != new string('1', 11))
            {
                var dsc = 0;
                var v = 0;
                for (int i = 0, j = 9; i < 9; i++, j--)
                {
                    v += (Convert.ToInt32(value[i].ToString()) * j);
                }

                var vl1 = v % 11;
                if (vl1 >= 10)
                {
                    vl1 = 0;
                    dsc = 2;
                }

                v = 0;
                for (int i = 0, j = 1; i < 9; ++i, ++j)
                {
                    v += (Convert.ToInt32(value[i].ToString()) * j);
                }

                var x = v % 11;
                var vl2 = (x >= 10) ? 0 : x - dsc;

                isValid = vl1.ToString() + vl2.ToString() == value.Substring(value.Length - 2, 2);

            }

            if (!isValid)
                AddError(message);

            return this;
        }
    }
}
