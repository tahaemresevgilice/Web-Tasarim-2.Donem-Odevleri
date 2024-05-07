using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace web14.Controllers
{
    public class AboutController : Controller
    {
        [Route("/About")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/Classes")]
        public IActionResult Classes()
        {
            return View();
        }
        [Route("/Blog")]
        public IActionResult Blog()
        {
            return View();
        }

        [Route("/Galery")]
        public IActionResult Galery()
        {
            return View();
        }

        [Route("/Contacts")]
        public IActionResult Contacts()
        {
            return View();
        }
        [Route("/Blog-Details")]
        public IActionResult BlogDetails()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}