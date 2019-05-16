using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_TempData.Models;

namespace Sol_TempData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            this.TempData["Data"] = "Kishor";

            //return View();
            return RedirectToAction("Privacy");
        }

        public IActionResult Privacy()
        {
            var data = this.TempData["Data"] as String;

            //return View();
            return RedirectToAction("Index", "RedirectNewHome");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}