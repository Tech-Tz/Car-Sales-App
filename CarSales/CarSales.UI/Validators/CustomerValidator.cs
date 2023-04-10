using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Validators
{
    public static class CustomerValidator
    {
        private const int maxLength = 100;

        public static readonly string NameInvalid = "Name invalid!";
        public static readonly string EmailInvalid = "Email invalid!";
        public static readonly string PhonenumberInvalid = "Phone number invalid!";

        public static bool IsValueEmpty(string value) => string.IsNullOrWhiteSpace(value);

        public static bool IsNameValid(string input) => !IsValueEmpty(input) && input.Length > 0 && input.Length <= maxLength;

        public static bool IsEmailValid(string input)
        {
            if (IsValueEmpty(input)) { return false; }
            else if (!input.Contains("@")) { return false; }
            else if (input.Contains(" ")) { return false; }
            else return true;
        }

        public static bool IsPhonenumberValid(string input) => !IsValueEmpty(input) && input.Length > 0 && input.Length <= maxLength;
    }
}
