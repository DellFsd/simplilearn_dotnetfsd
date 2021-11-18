using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phase2Section2._7.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Phase2Section2._7.Controllers
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

        [HttpPost]
        public ActionResult ViewDataRedirect(string name, string address, string course, string year)
        {
            ViewData["name"] = name;
            ViewData["address"] = address;
            ViewData["course"] = course;
            ViewData["year"] = year;

            return RedirectToAction("ViewDataSubmit");
        }

        [HttpPost]
        public ViewResult ViewDataSubmit(string name, string address, string course, string year)
        {
            ViewData["name"] = name;
            ViewData["address"] = address;
            ViewData["course"] = course;
            ViewData["year"] = year;

            return View();
        }


        [HttpPost]
        public ViewResult ViewBagSubmit()
        {
            ViewBag.name = Request.Form["name"];
            ViewBag.address = Request.Form["address"];
            ViewBag.course = Request.Form["course"];
            ViewBag.year = Request.Form["year"];

            return View();
        }

        [HttpPost]
        public ActionResult TempDataRedirect()
        {
            TempData["name"] = Request.Form["name"].ToString();
            TempData["address"] = Request.Form["address"].ToString();
            TempData["course"] = Request.Form["course"].ToString();
            TempData["year"] = Request.Form["year"].ToString();

            return RedirectToAction("TempDataSubmit");
        }

        public ViewResult TempDataSubmit()
        {
            return View();
        }

    }
}