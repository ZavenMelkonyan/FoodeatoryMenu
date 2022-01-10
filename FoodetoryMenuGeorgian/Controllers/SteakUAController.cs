using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodetoryMenuGeorgian.Models.SteakUA;

namespace FoodetoryMenuGeorgian.Controllers
{
    public class SteakUAController : Controller
    {
        [Route("/SteakUA")]
        public IActionResult SteakUA(FoodetoryMenuGeorgian.Models.HomeViewModel homeViewModel)
        {
            GeorgianUAViewModel barViewModel = new GeorgianUAViewModel() { categories = new Categories() };
            barViewModel.isQR = homeViewModel.isQR;
            return View("steakua", barViewModel);
        }
        [Route("/SteakUA_eng")]
        public IActionResult SteakUAEng(FoodetoryMenuGeorgian.Models.HomeViewModel homeViewModel)
        {
            GeorgianUAViewModel barViewModel = new GeorgianUAViewModel() { categories = new Categories() };
            barViewModel.isQR = homeViewModel.isQR;
            return View("steakua_eng", barViewModel);
        }
        public IActionResult Categorie(GeorgianUAViewModel barViewModel)
        {
            barViewModel.categories = new Categories();
            var model = barViewModel.categories.categories.Where(x => x.Name == barViewModel.categorieName ||
                                                                                   x.NameEng == barViewModel.categorieName).FirstOrDefault();
            model.isQR = barViewModel.isQR;
            return View("categorie", model);
        }
        public IActionResult CategorieEng(GeorgianUAViewModel barViewModel)
        {
            barViewModel.categories = new Categories();
            var model = barViewModel.categories.categories.Where(x => x.Name == barViewModel.categorieName ||
                                                                                   x.NameEng == barViewModel.categorieName).FirstOrDefault();
            model.isQR = barViewModel.isQR;
            return View("categorie_eng", model);
        }
        public IActionResult Product(FoodetoryMenuGeorgian.Models.SushiViewModel sushiViewModel)
        {
            Categories categories = new Categories();
            if (sushiViewModel.Lang == "Eng")
            {
                sushiViewModel.NameAndPrice = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                                           x.NameEng == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Name == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameEng == sushiViewModel.NameAndPrice).FirstOrDefault().NameEng;
                var tempModel = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                                           x.NameEng == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Description == sushiViewModel.Description ||
                                                                                                                                                   x.DescriptionEng == sushiViewModel.Description).FirstOrDefault();
                sushiViewModel.Description = tempModel == null ? null : tempModel.DescriptionEng;
            }
            if (sushiViewModel.Lang == "UA")
            {
                sushiViewModel.NameAndPrice = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                                           x.NameEng == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Name == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameEng == sushiViewModel.NameAndPrice).FirstOrDefault().Name;
                var tempModel = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                           x.NameEng == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Description == sushiViewModel.Description ||
                                                                                                                                   x.DescriptionEng == sushiViewModel.Description).FirstOrDefault();
                sushiViewModel.Description = tempModel == null ? null : tempModel.Description;

            }

            return View("product", sushiViewModel);
        }
        public IActionResult ProductEng(FoodetoryMenuGeorgian.Models.SushiViewModel sushiViewModel)
        {
            Categories categories = new Categories();
            sushiViewModel.NameAndPrice = categories.categories.Where(x => x.NameEng == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Name == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameEng == sushiViewModel.NameAndPrice).FirstOrDefault().NameEng;
            return View("product", sushiViewModel);
        }
    }
}
