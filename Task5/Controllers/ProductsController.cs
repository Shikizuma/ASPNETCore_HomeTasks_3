using Microsoft.AspNetCore.Mvc;
using Task5.Models;

namespace Task5.Controllers
{
    public class ProductsController : Controller
    {
       
        public IActionResult Index()
        {
            List<ProductModel> products = new List<ProductModel>();
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                products.Add(new ProductModel
                {
                    Id = i,
                    Price = Math.Round(random.NextDouble() * 1000, 2),
                    Name = $"Product{i}"
                });
            }


            //ViewBag.Products = products;
            return View(products);
        }
    }

}
