using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IT3047_Final_Project01.Models;


namespace IT3047_Final_Project01.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies2 = context.Movies2
                .OrderBy(m => m.Name)
                .ToList();
            return View(movies2);
        }
    }
}
