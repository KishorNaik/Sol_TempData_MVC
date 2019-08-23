using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_TempData.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            // Step 1 Excecute
            string data =(TempData["Data"] = "Kishor") as string;
            //ViewBag.Data = data;

            // Step 2 Excecute (Read & Keep Method)
            //TempData.Keep();

            // Step 3 Excecute (Peek & Read Method)
            ViewBag.Data = TempData.Peek("Data") as String;

            return View();
        }

        public IActionResult About()
        {
            // Step 1 Excecute
            //string data = TempData["Data"] as string;
            //ViewBag.Data = data;

            // Step 2 Excecute (Read & Keep Method)
            //TempData.Keep();

            // Step 3 Excecute (Peek & Read Method)
            ViewBag.Data = TempData.Peek("Data") as String;

            return View();
        }

        public IActionResult Contact()
        {
            // Step 1 Excecute
            // After Third Request you will not get Temp Data.
            //string data = TempData["Data"] as string;
            //ViewBag.Data = data;

            // Step 2 Excecute (Read & Keep Method)
            //TempData.Keep();

            // Step 3 Excecute (Peek & Read Method)
            ViewBag.Data = TempData.Peek("Data") as string;

            return View();
        }

        public IActionResult HomeIndex()
        {
            TempData.Keep();

            return RedirectToAction("Index", "Home");
        }
    }
}