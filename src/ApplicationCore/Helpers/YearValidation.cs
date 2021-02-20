using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Helpers
{
   public class YearValidation: ValidationAttribute
    {
        public YearValidation(int year)
        {
            Year = year;
        }
        public int Year { get; }

        public string GetErrorMessage() =>
            $"year should be no later than {Year}.";

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var year = ((DateTime?) value)?.Year;

            if (year<Year)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;

        }
    }
}
