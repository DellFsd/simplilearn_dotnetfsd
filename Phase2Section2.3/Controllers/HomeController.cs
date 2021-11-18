using System;
using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Phase2Section2._3.Models;

namespace Phase2Section2._3.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Info(string t)
        {
            ViewData["Message"] = "You have requested info for " + t;

            return View();
        }

        [HttpPost]
        public IActionResult StudentDetails(string t)
        {
            StringBuilder sb = new StringBuilder("<b>Student details entered:</b><br>");
            sb.Append("Name: " + Request.Form["name"].ToString() + "<br>");
            sb.Append("Address: " + Request.Form["address"].ToString() + "<br>");
            sb.Append("Subject: " + Request.Form["subject"].ToString() + "<br>");

            ViewData["message"] = sb.ToString();
            return View();
        }

    }
}
