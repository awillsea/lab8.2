using ControllerPractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControllerPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Sample()
        {
            return View();
        }
        public IActionResult Samplelogin(string firstname,string lastname,string email,string password)
        {
            ViewBag.Firstname = firstname;
            ViewBag.Lastname = lastname;
            ViewBag.Email = email;
            ViewBag.Password = password;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}