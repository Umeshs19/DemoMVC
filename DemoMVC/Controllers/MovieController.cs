using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using DemoMVC.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoMVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie { Id = 1, Name = "Tom", Year = 2001, Rating = 4 };
            return View(movie);
        }
        public IActionResult List()
        {
            List<Movie> movieList = GetMovies();
                return View(movieList);
        }
        public IActionResult Find()
        {
            return View();
        }
        public IActionResult Display(int id)
        {
            List<Movie> movies=GetMovies();
            Movie movie = (from m in movies where m.Id == id select m).FirstOrDefault();
            //Movie movie = movies.Where(m=>m.Id==id).FirstOrDefault();
            return View("Index", movie);
        }
        [HttpGet]
        public IActionResult FindByRating()
        {
            List<int> ratingList = new List<int> { 1, 2, 3, 4, 5 };
            ViewBag.rating = new SelectList(ratingList);
            return View();
        }
        [HttpPost]
        public IActionResult FindByRating(int rating)
        {
            List<Movie> movies = GetMovies();
            var data = from m in movies where m.Rating == rating select m;
            ViewBag.Data = data;
            List<int> ratingList = new List<int> { 1, 2, 3, 4, 5 };
            ViewBag.rating = new SelectList(ratingList);
            return View();
        }
        public List<Movie> GetMovies()
        {
            List<Movie> movieList = new List<Movie>()
            {
                new Movie { Id=1,Name="War",Year=2001,Rating=5},
                new Movie { Id=2,Name="Vikram",Year=2002,Rating=4},
                new Movie { Id=3,Name="Laxmi",Year=2003,Rating=3},
                new Movie { Id=4,Name="Pushpa",Year=2004,Rating=5},
                new Movie { Id=5,Name="Mass",Year=2005,Rating=3},
                new Movie { Id=6,Name="Bhuj",Year=2006,Rating=4},
                new Movie { Id=7,Name="Coolie",Year=2007,Rating=5}
            };
            return movieList;
        }
    }
}
