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
        public IActionResult Rolls()
        {
            return View("rolls");
        }
        public IActionResult RollsArm()
        {
            return View("rolls_arm");
        }
        public IActionResult RollsRus()
        {
            return View("rolls_rus");
        }
        public IActionResult HotRolls()
        {
            return View("hotrolls");
        }
        public IActionResult HotRollsArm()
        {
            return View("hotrolls_arm");
        }
        public IActionResult HotRollsRus()
        {
            return View("hotrolls_rus");
        }
        public IActionResult FriedRolls()
        {
            return View("friedrolls");
        }
        public IActionResult FriedRollsArm()
        {
            return View("friedrolls_arm");
        }
        public IActionResult FriedRollsRus()
        {
            return View("friedrolls_rus");
        }
        public IActionResult Sushi()
        {
            return View("sushi");
        }
        public IActionResult SushiArm()
        {
            return View("sushi_arm");
        }
        public IActionResult SushiRus()
        {
            return View("sushi_rus");
        }
        public IActionResult Gunkan()
        {
            return View("gunkan");
        }
        public IActionResult GunkanArm()
        {
            return View("gunkan_arm");
        }
        public IActionResult GunkanRus()
        {
            return View("gunkan_rus");
        }
        public IActionResult Temaki()
        {
            return View("temaki");
        }
        public IActionResult TemakiArm()
        {
            return View("temaki_arm");
        }
        public IActionResult TemakiRus()
        {
            return View("temaki_rus");
        }
        public IActionResult Sashimi()
        {
            return View("sashimi");
        }
        public IActionResult SashimiArm()
        {
            return View("sashimi_arm");
        }
        public IActionResult SashimiRus()
        {
            return View("sashimi_rus");
        }
        public IActionResult Other()
        {
            return View("other");
        }
        public IActionResult OtherArm()
        {
            return View("other_arm");
        }
        public IActionResult OtherRus()
        {
            return View("other_rus");
        }
        public IActionResult Salads()
        {
            return View("salads");
        }
        public IActionResult SaladsArm()
        {
            return View("salads_arm");
        }
        public IActionResult SaladsRus()
        {
            return View("salads_rus");
        }
        public IActionResult Soups()
        {
            return View("soups");
        }
        public IActionResult SoupsArm()
        {
            return View("soups_arm");
        }
        public IActionResult SoupsRus()
        {
            return View("soups_rus");
        }
        public IActionResult Wok()
        {
            return View("wok");
        }
        public IActionResult WokArm()
        {
            return View("wok_arm");
        }
        public IActionResult WokRus()
        {
            return View("wok_rus");
        }
        public IActionResult Sets()
        {
            return View("sets");
        }
        public IActionResult SetsArm()
        {
            return View("sets_arm");
        }
        public IActionResult SetsRus()
        {
            return View("sets_rus");
        }
    }
}
