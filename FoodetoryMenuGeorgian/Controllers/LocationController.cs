using FoodetoryMenuGeorgian.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodetoryMenuGeorgian.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Barekamutyun(bool isQR)
        {
            return View("barekamutyun",new HomeViewModel { isQR = isQR });
        }
        public IActionResult BarekamutyunArm(bool isQR)
        {
            return View("barekamutyun_arm", new HomeViewModel { isQR = isQR });
        }
        public IActionResult BarekamutyunRus(bool isQR)
        {
            return View("barekamutyun_rus", new HomeViewModel { isQR = isQR });
        }
        public IActionResult Kiev(bool isQR)
        {
            return View("kiev", new HomeViewModel { isQR = isQR });
        }
        public IActionResult KievEng(bool isQR)
        {
            return View("kiev_eng", new HomeViewModel { isQR = isQR });
        }
    }
}
