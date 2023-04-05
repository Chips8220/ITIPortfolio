using Microsoft.AspNetCore.Mvc;
using RazorEx1.Models;

namespace RazorEx1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            Product[] array =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };
            return View(array);
        }
    }
}
