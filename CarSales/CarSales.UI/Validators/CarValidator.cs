using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI.Validators
{
    public static class CarValidator
    {
        private const int manufacturedYearMin = 1990;
        private static readonly int manufacturedYearMax = DateTime.Now.Year;
        private const int maxLength = 100;

        public static readonly string VehicleIdNumberInvalid = "Vehicle id number invalid!";
        public static readonly string ManufacturerInvalid = "Manufacturer invalid!";
        public static readonly string ManufacturedYearInvalid = $"Manufacturered year must be between {manufacturedYearMin} and {manufacturedYearMax}!";
        public static readonly string ModelInvalid = "Model invalid!";
        public static readonly string PriceInvalid = "Price invalid!";
        public static readonly string DistanceCoveredInvalid = "Distance covered invalid!";

        public static bool IsValueEmpty(string value) => string.IsNullOrWhiteSpace(value);

        public static bool IsManufacturerInputValid(string input) => !IsValueEmpty(input) && input.Length > 0 && input.Length <= maxLength;

        public static bool IsManufacturedYearInputValid(string input)
        {
            if (IsValueEmpty(input)) { return false; }
            var isDigit = int.TryParse(input, out int year);
            return isDigit && year >= manufacturedYearMin && year <= manufacturedYearMax;
        }

        public static bool IsPriceInputValid(string input) => !IsValueEmpty(input) && decimal.TryParse(input, out var value);

        public static bool IsModelInputValid(string input) => !IsValueEmpty(input) && input.Length > 0 && input.Length <= maxLength;

        public static bool IsDistanceCoveredValid(string input) => IsValueEmpty(input) || decimal.TryParse(input, out var value);

        public static bool IsVINValid(string input) => !IsValueEmpty(input) && input.Length > 0 && input.Length <= maxLength;
    }
}
