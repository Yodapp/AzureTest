using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AzureTest.Models;

namespace AzureTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var nerd = new Nerd
            {
                Age = 38,
                Name = "Daniel Nordmark"
            };


            return View(nerd);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
