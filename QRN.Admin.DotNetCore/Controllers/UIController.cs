using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QRN.Admin.Models;

namespace QRN.Admin.Controllers
{
    public class UIController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Widgets");
        }

        public IActionResult Widgets()
        {
            return View();
        }

        public IActionResult Buttons()
        {
            return View();
        }

        public IActionResult Notifications()
        {
            return View();
        }

        public IActionResult Icons()
        {
            return View();
        }
    }
}
