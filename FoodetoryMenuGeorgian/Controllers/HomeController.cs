using FoodetoryMenuGeorgian.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(bool isQR)
        {
            return View(new HomeViewModel { isQR = isQR});
        }
        public IActionResult IndexArm(bool isQR)
        {
            return View("Index_arm",new HomeViewModel { isQR = isQR });
        }
        public IActionResult IndexRus(bool isQR)
        {
            return View("Index_rus",new HomeViewModel { isQR = isQR });
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
