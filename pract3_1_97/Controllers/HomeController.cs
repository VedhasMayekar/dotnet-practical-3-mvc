using Microsoft.AspNetCore.Mvc;
using pract3_1_97.Models;
namespace pract3_1_97.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new stockQuote { Symbol = "Nike", Price = 3500 };
            return View(model);
        }
    }
}
