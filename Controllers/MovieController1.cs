using Microsoft.AspNetCore.Mvc;
using SpiderManMoviesApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpiderManMoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        // قائمة أفلام سبيدر-مان المخزنة في الذاكرة
        private static readonly List<Movie> _movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Spider-Man", Director = "Sam Raimi", ReleaseYear = 2002 },
            new Movie { Id = 2, Title = "Spider-Man 2", Director = "Sam Raimi", ReleaseYear = 2004 },
            new Movie { Id = 3, Title = "Spider-Man 3", Director = "Sam Raimi", ReleaseYear = 2007 },
            new Movie { Id = 4, Title = "Spider-Man: Into the Spider-Verse", Director = "Bob Persichetti", ReleaseYear = 2018 },
            new Movie { Id = 5, Title = "Spider-Man: Across the Spider-Verse", Director = "Joaquim Dos Santos", ReleaseYear = 2023 }
        };

        // عرض قائمة الأفلام
        public IActionResult Index()
        {
            return View(_movies);
        }

        // عرض تفاصيل فيلم معين باستخدام الـ Id
        public IActionResult Details(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
    }
}