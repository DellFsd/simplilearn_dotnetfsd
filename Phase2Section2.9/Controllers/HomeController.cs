using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phase2Section2._9.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Phase2Section2._9.Controllers
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

        public ActionResult FormGet(string name, string email, string course, string address)
        {
            ViewData["name"] = name;
            ViewData["email"] = email;
            ViewData["course"] = course;
            ViewData["address"] = address;
            ViewData["Title"] = "Form Get";
            ViewData["Method"] = "Get";
            return View("Student");
        }

        [HttpPost]
        public ActionResult FormPost(string name, string address, string email, string course, string temp)
        {
            ViewData["name"] = name;
            ViewData["email"] = email;
            ViewData["course"] = course;
            ViewData["address"] = address;
            ViewData["Title"] = "Form Get";
            ViewData["Method"] = "Post";
            return View("Student");
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
