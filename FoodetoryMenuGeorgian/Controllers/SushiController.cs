using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodetoryMenuGeorgian.Models;

namespace FoodetoryMenuGeorgian.Controllers
{

    public class SushiController : Controller
    {
        IConfiguration configuration;

        public SushiController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        [Route("/Sushi")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Sushi_arm")]
        public IActionResult IndexArm()
        {
            return View("index_arm");
        }
        [Route("/Sushi_rus")]
        public IActionResult IndexRus()
        {
            return View("index_rus");
        }
        public IActionResult Maki()
        {
            return View("maki");
        }
        public IActionResult MakiArm()
        {
            return View("maki_arm");
        }
        public IActionResult MakiRus()
        {
            return View("maki_rus");
        }
    }
}
