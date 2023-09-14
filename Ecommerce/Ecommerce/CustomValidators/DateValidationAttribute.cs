using System.ComponentModel.DataAnnotations;

namespace Ecommerce.CustomValidators
{
    public class DateValidationAttribute : ValidationAttribute
    {
        public string Date { get; set; } = "2000 - 01 - 01";
        public string DefatultErrorMessage { get; set; } = "Invalid Date cant be more than {0}";

        public DateValidationAttribute()
        {

        }

        public DateValidationAttribute(string dateInput)
        {
            Date = dateInput;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                try
                {
                    DateTime date = Convert.ToDateTime(value);
                    if (date > Convert.ToDateTime(Date))
                    {
                        return new ValidationResult(string.Format(ErrorMessage ?? DefatultErrorMessage, Date));
                    }
                    
                }
                catch
                {
                    return new ValidationResult("Invalid Date");
                }


            }

            return ValidationResult.Success;
        }

    }
}

