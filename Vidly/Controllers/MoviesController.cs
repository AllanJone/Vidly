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
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Iron Man" };
            //return View(movie);

            ViewData["Movie"] = movie;
            ViewBag.Movie = movie;

            var customers = new List<Customer>
            {
                new Customer(){ Name = "Customer1" },
                new Customer(){ Name = "Customer2" },
                new Customer(){ Name = "Customer3" },
                new Customer(){ Name = "Customer4" },
                new Customer(){ Name = "Customer5" },
                new Customer(){ Name = "Customer6" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //public ActionResult Edit(int id)
        //{
        //    return Content("id is " + id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0} and sortBy={1}",pageIndex,sortBy));
        //}

        [Route("movies/release/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}