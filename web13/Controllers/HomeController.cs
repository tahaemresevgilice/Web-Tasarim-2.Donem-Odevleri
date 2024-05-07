using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web13.Models;

namespace web13.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public IActionResult Index()
    {
        return View();
    }
    [Route("/About")]
    public IActionResult About()
    {
        return View();
    }
    [Route("/Contact")]
     public IActionResult Contact()
    {
        return View();
    }
    [Route("/Home/Slider-Home")]
    public IActionResult Slider()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
