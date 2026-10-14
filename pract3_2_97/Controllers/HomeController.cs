using Microsoft.AspNetCore.Mvc;
using pract3_2_97.Models;
namespace pract3_2_97.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Books>
            {
                new Books { Id = 1, Title = "Wings of Fire An Autobiography", Author = "Arun Tiwari", Price = 400 },
                new Books { Id = 2, Title = "The Silent Patient", Author = "Alex Michaelides", Price = 250 },
                new Books { Id = 3, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 200 },
                new Books { Id = 4, Title = "The Alchemist", Author = "Paulo Coelho", Price = 300 },
                new Books { Id = 5, Title = "The Perfect Murder", Author = "Ruskin Bond", Price = 210 }
            };
            return View(books);
        }
    }
}
