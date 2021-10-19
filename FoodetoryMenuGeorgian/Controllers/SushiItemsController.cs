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

            Products products = new Products();
            string newName = products.products.Where(x => x.Item1 == model.NameAndPrice.Substring(0, index).Trim()
                                      || x.Item2 == model.NameAndPrice.Substring(0, index).Trim()
                                      || x.Item3 == model.NameAndPrice.Substring(0, index).Trim()).FirstOrDefault().Item1;
            model.NameAndPrice = model.NameAndPrice.Replace(model.NameAndPrice.Substring(0, index).Trim(), newName);
            index = model.NameAndPrice.IndexOf(Regex.Match(model.NameAndPrice, @"\d+").Value[0]);

            Categories categories = new Categories();
            string newCategory = categories.categories.Where(x => x.Item1 == model.MenuName
                                      || x.Item2 == model.MenuName
                                      || x.Item3 == model.MenuName).FirstOrDefault().Item1;
            model.MenuName = newCategory;

            Description descriptions = new Description();
            model.Description = descriptions.descriptions[model.NameAndPrice.Substring(0, index).Trim()];
            return View(model);
        }
        public IActionResult IndexArm(SushiViewModel model)
        {
            int index = model.NameAndPrice.IndexOf(Regex.Match(model.NameAndPrice, @"\d+").Value[0]);

            Products products = new Products();
            string newName = products.products.Where(x => x.Item1 == model.NameAndPrice.Substring(0, index).Trim()
                                      || x.Item2 == model.NameAndPrice.Substring(0, index).Trim()
                                      || x.Item3 == model.NameAndPrice.Substring(0, index).Trim()).FirstOrDefault().Item2;
            model.NameAndPrice = model.NameAndPrice.Replace(model.NameAndPrice.Substring(0, index).Trim(), newName);
            index = model.NameAndPrice.IndexOf(Regex.Match(model.NameAndPrice, @"\d+").Value[0]);

            Categories categories = new Categories();
            string newCategory = categories.categories.Where(x => x.Item1 == model.MenuName
                                      || x.Item2 == model.MenuName
                                      || x.Item3 == model.MenuName).FirstOrDefault().Item2;
            model.MenuName = newCategory;

            DescriptionArm descriptions = new DescriptionArm();
            model.Description = descriptions.descriptions[model.NameAndPrice.Substring(0, index).Trim()];
            return View("index", model);
        }
        public IActionResult IndexRus(SushiViewModel model)
        {
            int index = model.NameAndPrice.IndexOf(Regex.Match(model.NameAndPrice, @"\d+").Value[0]);

            Products products = new Products();
            string newName = products.products.Where(x => x.Item1 == model.NameAndPrice.Substring(0, index).Trim()
                                      || x.Item2 == model.NameAndPrice.Substring(0, index).Trim()
                                      || x.Item3 == model.NameAndPrice.Substring(0, index).Trim()).FirstOrDefault().Item3;
            model.NameAndPrice = model.NameAndPrice.Replace(model.NameAndPrice.Substring(0, index).Trim(), newName);
            index = model.NameAndPrice.IndexOf(Regex.Match(model.NameAndPrice, @"\d+").Value[0]);

            Categories categories = new Categories();
            string newCategory = categories.categories.Where(x => x.Item1 == model.MenuName
                                      || x.Item2 == model.MenuName
                                      || x.Item3 == model.MenuName).FirstOrDefault().Item3;
            model.MenuName = newCategory;

            DescriptionRus descriptions = new DescriptionRus();
            model.Description = descriptions.descriptions[model.NameAndPrice.Substring(0, index).Trim()];
            return View("index", model);
        }
    }
}

