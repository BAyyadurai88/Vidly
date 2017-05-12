using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var newMovie = new Movie(){ Name = "Shrek!"};

            #region return View() - Explanation
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model = newMovie;
            //return viewResult;
            // Equivalent of return View(newMovie);
            #endregion

            var viewModel = new RandomMovieViewModel();
            viewModel.Movie = newMovie;
            viewModel.Customers = new List<Customer>
            {
                new Customer{Name = "Cusomter 1"},
                new Customer{Name = "Cusomter 2"}
            };

            return View(viewModel); //Std return result

            //return Content("Hello World");  // To return text content
            //return new EmptyResult(); // No response - empty return - dont have a object new have to create a new obj
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new {page = 1, sortby = "name"}); // redirect to another action - action, controler and anonymous paramerters object
        }

        /// <summary>
        /// Function to edit the movie with movie id param
        /// </summary>
        /// <param name="Id"></param> // Route config has parameter as id and hence needed to be same for url query
        /// <returns></returns>
        public ActionResult Edit(int Id)
        {
            return Content("Id =" + Id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}