﻿using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.Controllers
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
        public IActionResult MYTEST()
        {
            return Content("Hello World");
        }
        public IActionResult CurrentTime()
        {
            Request.ContentType = "application/text/html";
            DateTime current = DateTime.Now;
            return Content($"The Current<b> Date<b> and time is {current.ToString()}");
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult ProcessLogin(string username, string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
            //return Content($"{username} {password}");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}