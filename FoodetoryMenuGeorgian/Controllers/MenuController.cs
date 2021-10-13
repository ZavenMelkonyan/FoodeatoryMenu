using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Controllers
{
    public class MenuController : Controller
    {
        [Route("/Menu")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Menu_arm")]
        public IActionResult IndexArm()
        {
            return View("index_arm");
        }
    }
}
