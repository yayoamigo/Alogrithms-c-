using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class OrderController : Controller
    {
        [Route("/orders")]
        public IActionResult Index([Bind(nameof(Order.InvoicePrice), nameof(Order.Products), nameof(Order.OrderDate))]Order order)
        {
            if (!ModelState.IsValid)
            {
                string error = string.Join("\n",
                    ModelState.Values.SelectMany(errors => errors.Errors).Select(err => err.ErrorMessage));

                return BadRequest(error);
            }

            Random random = new Random();
            int orderNumber = random.Next(1, 999999);
            order.OrderNo = orderNumber;
            return Content($"{order}");
        }
    }
}
