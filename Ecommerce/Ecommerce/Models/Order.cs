using System.ComponentModel.DataAnnotations;
using Ecommerce.CustomValidators;

namespace Ecommerce.Models
{
    public class Order 
    {
        
        
        public int? OrderNo { get; set; }

        [Required(ErrorMessage = "{0}  must be present")]
        [DateValidation("2005-01-01")]
        public DateTime? OrderDate { get; set; }

        [Required(ErrorMessage = "{0}  must be present")]
        [Range(1, double.MaxValue, ErrorMessage = "{0} should be between a valid number")]
        [InvoiceValidator]
        public double? InvoicePrice { get; set; }

        [ListValidaton(ErrorMessage = "Order should have at least one product")]
        public List<Product> Products { get; set; } = new List<Product>();

        public override string ToString()
        {
            string productsString = "";
            foreach (var product in Products)
            {
                productsString += product.ToString() + ", ";
            }
            

            return $"Order No: {OrderNo}, Order Date: {OrderDate}, Products: {productsString}";
        }



    }
}
