﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{Name = "C1"},
                new Customer{Name = "C2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Name = "Inception"
                },
                new Movie
                {
                    Id = 2,
                    Name = "Tenet"
                }
    
            };
        }
    }
}