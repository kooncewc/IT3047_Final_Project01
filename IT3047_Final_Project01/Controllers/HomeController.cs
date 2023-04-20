using Microsoft.AspNetCore.Mvc;


namespace IT3047_Final_Project01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
           return View();
        }

        
    }
}

