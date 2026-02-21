using Microsoft.AspNetCore.Mvc;
using Mission06_Vizcarra.Data;      // <-- your DbContext namespace
using Mission06_Vizcarra.Models;    // <-- your Movie model namespace
using System.Linq;

namespace Mission06_Vizcarra.Controllers
{
    public class MoviesController : Controller
    {
        private MovieCollectionContext _context;

        public MoviesController(MovieCollectionContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            var movies = _context.Movies
                .OrderBy(m => m.Title)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.MovieId == id);
            if (movie == null) return NotFound();

            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            _context.Movies.Update(movie);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.MovieId == id);
            if (movie == null) return NotFound();

            return View(movie);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int movieId)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.MovieId == movieId);
            if (movie == null) return NotFound();

            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
