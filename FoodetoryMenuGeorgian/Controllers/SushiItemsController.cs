using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodetoryMenuGeorgian.Models;
using System.Text.RegularExpressions;

namespace FoodetoryMenuGeorgian.Controllers
{
    public class SushiItemsController : Controller
    {
        public IActionResult Index(SushiViewModel model)
        {
            int index = model.NameAndPrice.IndexOf(Regex.Match(model.NameAndPrice, @"\d+").Value[0]);
            Description descriptions = new Description();
            model.Description = descriptions.descriptions[model.NameAndPrice.Substring(0, index).Trim()];
            return View(model);
        }
    }
}
