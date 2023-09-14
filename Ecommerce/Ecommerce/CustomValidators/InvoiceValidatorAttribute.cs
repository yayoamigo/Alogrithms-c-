using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Ecommerce.Models;

namespace Ecommerce.CustomValidators
{
    public class InvoiceValidatorAttribute : ValidationAttribute
    {

        public string DefaultErrorMessage { get; set; } = "Invoice price should be equal to {0} and it was {1}";
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null) {
             double invoice = Convert.ToDouble(value);
             PropertyInfo? Products = validationContext.ObjectType.GetProperty(nameof(Order.Products));
                if (Products != null)
                {
                    List<Product> products = (List<Product>)Products.GetValue(validationContext.ObjectInstance);


                    double totalPrice = 0;
                    foreach (Product product in products)
                    {
                        totalPrice += product.Price * product.Quantity;
                    }
                    if (totalPrice > 0)
                    {
                        //if the value of "InvoicePrice" property is not equal to the total cost of all products in the order
                        if (totalPrice != invoice)
                        {
                            //return model error
                            return new ValidationResult(string.Format(ErrorMessage ?? DefaultErrorMessage, totalPrice, invoice), new string[] { nameof(validationContext.MemberName) });
                        }
                    }
                    else
                    {
                        //return model error is no products found
                        return new ValidationResult("No products found to validate invoice price", new string[] { nameof(validationContext.MemberName) });
                    }

                    //No validation error
                    return ValidationResult.Success;
                }
                return null;
            }
            else
                return null;
        }
    }
 }
 