using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodetoryMenuGeorgian.Models.Steak;

namespace FoodetoryMenuGeorgian.Controllers
{
    public class SteakController : Controller
    {
        [Route("/Steak")]
        public IActionResult Steak(FoodetoryMenuGeorgian.Models.HomeViewModel homeViewModel)
        {
            SteakViewModel steakViewModel = new SteakViewModel() { categories = new Categories()};
            steakViewModel.isQR = homeViewModel.isQR;
            return View("steak", steakViewModel);
        }
        [Route("/Steak_arm")]
        public IActionResult SteakArm(FoodetoryMenuGeorgian.Models.HomeViewModel homeViewModel)
        {
            SteakViewModel steakViewModel = new SteakViewModel() { categories = new Categories() };
            steakViewModel.isQR = homeViewModel.isQR;
            return View("steak_arm", steakViewModel);
        }
        [Route("/Steak_rus")]
        public IActionResult SteakRus(FoodetoryMenuGeorgian.Models.HomeViewModel homeViewModel)
        {
            SteakViewModel steakViewModel = new SteakViewModel() { categories = new Categories() };
            steakViewModel.isQR = homeViewModel.isQR;
            return View("steak_rus", steakViewModel);
        }
        public IActionResult Categorie(SteakViewModel steakViewModel)
        {
            steakViewModel.categories = new Categories();
            var model = steakViewModel.categories.categories.Where(x => x.Name == steakViewModel.categorieName ||
                                                                                   x.NameArm == steakViewModel.categorieName ||
                                                                                   x.NameRus == steakViewModel.categorieName).FirstOrDefault();
            model.isQR = steakViewModel.isQR;
            return View("categorie", model);
        }
        public IActionResult CategorieArm(SteakViewModel steakViewModel)
        {
            steakViewModel.categories = new Categories();
            var model = steakViewModel.categories.categories.Where(x => x.Name == steakViewModel.categorieName ||
                                                                                   x.NameArm == steakViewModel.categorieName ||
                                                                                   x.NameRus == steakViewModel.categorieName).FirstOrDefault();
            model.isQR = steakViewModel.isQR;
            return View("categorie_arm", model);
        }
        public IActionResult CategorieRus(SteakViewModel steakViewModel)
        {
            steakViewModel.categories = new Categories();
            var model = steakViewModel.categories.categories.Where(x => x.Name == steakViewModel.categorieName ||
                                                                                   x.NameArm == steakViewModel.categorieName ||
                                                                                   x.NameRus == steakViewModel.categorieName).FirstOrDefault();
            model.isQR = steakViewModel.isQR;
            return View("categorie_rus", model);
        }
        public IActionResult Product(FoodetoryMenuGeorgian.Models.SushiViewModel sushiViewModel)
        {
            Categories categories = new Categories();
            if (sushiViewModel.Lang == "Eng")
            {
                sushiViewModel.NameAndPrice = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                                           x.NameArm == sushiViewModel.MenuName ||
                                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Name == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameArm == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameRus == sushiViewModel.NameAndPrice).FirstOrDefault().Name;
                var tempModel = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                                           x.NameArm == sushiViewModel.MenuName ||
                                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Description == sushiViewModel.Description ||
                                                                                                                                                   x.DescriptionArm == sushiViewModel.Description ||
                                                                                                                                                   x.DescriptionRus == sushiViewModel.Description).FirstOrDefault();
                sushiViewModel.Description = tempModel == null ? null : tempModel.Description;
            }
            if (sushiViewModel.Lang == "Arm")
            {
                sushiViewModel.NameAndPrice = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                                           x.NameArm == sushiViewModel.MenuName ||
                                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Name == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameArm == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameRus == sushiViewModel.NameAndPrice).FirstOrDefault().NameArm;
                var tempModel = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                           x.NameArm == sushiViewModel.MenuName ||
                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Description == sushiViewModel.Description ||
                                                                                                                                   x.DescriptionArm == sushiViewModel.Description ||
                                                                                                                                   x.DescriptionRus == sushiViewModel.Description).FirstOrDefault();
                sushiViewModel.Description = tempModel == null ? null : tempModel.DescriptionArm;

            }
            if (sushiViewModel.Lang == "Rus")
            {
                sushiViewModel.NameAndPrice = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                                           x.NameArm == sushiViewModel.MenuName ||
                                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Name == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameArm == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameRus == sushiViewModel.NameAndPrice).FirstOrDefault().NameRus;
                var tempModel = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                           x.NameArm == sushiViewModel.MenuName ||
                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Description == sushiViewModel.Description ||
                                                                                                                                   x.DescriptionArm == sushiViewModel.Description ||
                                                                                                                                   x.DescriptionRus == sushiViewModel.Description).FirstOrDefault();
                sushiViewModel.Description = tempModel == null ? null : tempModel.DescriptionRus;

            }

            return View("product",sushiViewModel);
        }
        public IActionResult ProductArm(FoodetoryMenuGeorgian.Models.SushiViewModel sushiViewModel)
        {
            Categories categories = new Categories();
            sushiViewModel.NameAndPrice = categories.categories.Where(x => x.NameArm == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Name == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameArm == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameRus == sushiViewModel.NameAndPrice).FirstOrDefault().NameArm;
            return View("product", sushiViewModel);
        }
        public IActionResult ProductRus(FoodetoryMenuGeorgian.Models.SushiViewModel sushiViewModel)
        {
            Categories categories = new Categories();
            sushiViewModel.NameAndPrice = categories.categories.Where(x => x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Name == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameArm == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameRus == sushiViewModel.NameAndPrice).FirstOrDefault().NameRus;
            return View("product", sushiViewModel);
        }
    }
}
