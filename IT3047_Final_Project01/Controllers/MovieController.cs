using System.Linq;
using Microsoft.AspNetCore.Mvc;
using IT3047_Final_Project01.Models;

namespace IT3047_Final_Project01.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext context { get; set; }

        public MovieController(MovieContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new MovieModel());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var movie = context.Movies2.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieModel movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.MovieId == 0)
                    context.Movies2.Add(movie);
                else
                    context.Movies2.Update(movie);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (movie.MovieId == 0) ? "Add" : "Edit";
                return View(movie);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.Movies2.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieModel movie)
        {
            context.Movies2.Remove(movie);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
