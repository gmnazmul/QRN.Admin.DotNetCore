using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QRN.Admin.Models;

namespace QRN.Admin.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("LongText");
        }

        public IActionResult LongText()
        {
            return View();
        }

        public IActionResult UserProfile()
        {
            return View();
        }

        public IActionResult Blank()
        {
            return View();
        }
    }
}
