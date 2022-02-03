using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieDatabase.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabase.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _movieContext { get; set; }

        //Constructor
        public HomeController(MovieContext someName)
        {
            _movieContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FillOutMovieForm ()
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            
            return View("MovieForm");
        }

        [HttpPost]
        public IActionResult FillOutMovieForm(NewMovieResponse ar)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Add(ar);
                _movieContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList();

                return View(ar);
            }

        }

        public IActionResult Podcast ()
        {
            return View("Podcast");
        }

        public IActionResult MovieList ()
        {
            var applications = _movieContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Category.CategoryName)
                .ToList();
            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            var application = _movieContext.responses.Single(x => x.MovieID == movieid);

            return View("MovieForm", application);
        }

        [HttpPost]
        public IActionResult Edit(NewMovieResponse movie)
        {
            _movieContext.Update(movie);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var application = _movieContext.responses.Single(x => x.MovieID == movieid);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(NewMovieResponse ar)
        {
            _movieContext.responses.Remove(ar);
            _movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
