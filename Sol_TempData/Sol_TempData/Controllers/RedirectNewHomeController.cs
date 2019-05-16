using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_TempData.Controllers
{
    public class RedirectNewHomeController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.Data = this.TempData["Data"] as String;

            return View();
        }
    }
}