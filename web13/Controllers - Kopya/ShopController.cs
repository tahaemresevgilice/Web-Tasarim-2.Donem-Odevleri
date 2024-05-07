using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace web13.Controllers
{
    public class ShopController : Controller
    {
        private readonly ILogger<ShopController> _logger;

        public ShopController(ILogger<ShopController> logger)
        {
            _logger = logger;
        }
        [Route("/Shop")]
        public IActionResult Shop()
        {
            return View();
        }
        [Route("/Shop/Check-Out")]
        public IActionResult CheckOut()
        {
            return View();
        }
        [Route("/Shop/Single-Product")]
        public IActionResult SingleProduct()
        {
            return View();
        }
        [Route("/Shop/Cart")]
        public IActionResult Cart()
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