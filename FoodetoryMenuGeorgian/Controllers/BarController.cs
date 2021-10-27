using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodetoryMenuGeorgian.Models.Bar;

namespace FoodetoryMenuGeorgian.Controllers
{
    public class BarController : Controller
    {
        [Route("/Bar")]
        public IActionResult Bar()
        {
            BarViewModel barViewModel = new BarViewModel() { categories = new Categories()};
            return View("bar", barViewModel);
        }
        [Route("/Bar_arm")]
        public IActionResult BarArm()
        {
            BarViewModel barViewModel = new BarViewModel() { categories = new Categories() };
            return View("bar_arm", barViewModel);
        }
        [Route("/Bar_rus")]
        public IActionResult BarRus()
        {
            BarViewModel barViewModel = new BarViewModel() { categories = new Categories() };
            return View("bar_rus", barViewModel);
        }
    }
}
