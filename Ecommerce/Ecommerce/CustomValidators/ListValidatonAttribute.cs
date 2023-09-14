using Ecommerce.Models;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.CustomValidators
{
    public class ListValidatonAttribute : ValidationAttribute
    {
        public string DefaultErrorMessage { get; set; } = "Order should have at least one product";
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value != null)
            {
                List<Product> products = (List<Product>)value;

                if(products.Count == 0) {
                    return new ValidationResult(ErrorMessage ?? DefaultErrorMessage, new string[] { nameof(validationContext.MemberName) });
                }

                return ValidationResult.Success;
            }
            return null;
        }
    }
}
