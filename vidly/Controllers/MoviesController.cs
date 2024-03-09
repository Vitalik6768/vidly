using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;
using Vidly.Models;



namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1 "},
                new Customer { Name = "Customer 2 "}
            };

            var viewModel = new RundomMovieViewModel
            {
                Movie = movie,
                Customers = customers,
            };

            //Passing data
           // var viewResult = new ViewResult();
           // viewResult.ViewData.Model = movie;

            //optional

            return View(viewModel);


            //return View(movie);



            // return Content("hello world");
            //return HttpNotFound();
        }

        public ActionResult Edit(int movieId)
        {
            return Content("movieId = " + movieId);
      
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue) {

                pageIndex = 1;
            }

            if(String.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
            
        }

        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }





    }
}