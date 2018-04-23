using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DecisionMatrixWidget.Models;

namespace DecisionMatrixWidget.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Example");
        }

        public IActionResult Example()
        {
            ViewData["Message"] = "Decision Matrix Widget example.";

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
