using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;
        private MovieContext _movieContext { get; set; }

        //Constructor
        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            _movieContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FillOutMovieForm ()
        {
            return View("MovieForm");
        }

        [HttpPost]
        public IActionResult FillOutMovieForm(NewMovieResponse ar)
        {
            _movieContext.Add(ar);
            _movieContext.SaveChanges();

            return View("Confirmation", ar);
        }

        public IActionResult Podcast ()
        {
            return View("Podcast");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
