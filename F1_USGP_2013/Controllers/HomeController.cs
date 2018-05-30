using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using F1_USGP_2013.Models;

namespace F1_USGP_2013.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome To - USGP F1 2013";

            return View();
        
        }

        public IActionResult PhotoGallery()
        {
            ViewData["Message"] = "USGP F1 2013 - Photo Gallery";

            return View();
        }

        public IActionResult VideoGallery()
        {
            ViewData["Message"] = "USGP F1 2013 - Video Gallery";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
