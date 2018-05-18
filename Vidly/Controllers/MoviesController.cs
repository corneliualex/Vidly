using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private IEnumerable<Movie> _movies = new List<Movie>
        {
            new Movie {Id = 1,Name ="Shrek !" },
            new Movie {Id =2 ,Name="Wall-e" }
        };

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek !" };
            var customers = new List<Customer>
            {
                new Customer {Name ="Customer 1" },
                new Customer {Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
        
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
        
        public ActionResult Index()
        {
            return View(_movies);
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(String.Format("year={0}&month={1}",year,month));
        }

       
    }
}