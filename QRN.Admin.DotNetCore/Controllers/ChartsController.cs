using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QRN.Admin.Models;

namespace QRN.Admin.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("ChartJs");
        }

        public IActionResult ChartJs()
        {
            return View();
        }

        public IActionResult Inline()
        {
            return View();
        }
    }
}
