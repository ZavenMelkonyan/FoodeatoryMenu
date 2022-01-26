using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodetoryMenuGeorgian.Models.RossiaMall.Italy;

namespace FoodetoryMenuGeorgian.Controllers
{
    public class ItalyRMController : Controller
    {
        public IActionResult Italy(FoodetoryMenuGeorgian.Models.HomeViewModel homeViewModel)
        {
            ItalyViewModel italyViewModel = new ItalyViewModel() { categories = new Categories()};
            italyViewModel.isQR = homeViewModel.isQR;
            return View("italy", italyViewModel);
        }
        public IActionResult ItalyArm(FoodetoryMenuGeorgian.Models.HomeViewModel homeViewModel)
        {
            ItalyViewModel italyViewModel = new ItalyViewModel() { categories = new Categories() };
            italyViewModel.isQR = homeViewModel.isQR;
            return View("italy_arm", italyViewModel);
        }
        public IActionResult ItalyRus(FoodetoryMenuGeorgian.Models.HomeViewModel homeViewModel)
        {
            ItalyViewModel italyViewModel = new ItalyViewModel() { categories = new Categories() };
            italyViewModel.isQR = homeViewModel.isQR;
            return View("italy_rus", italyViewModel);
        }
        public IActionResult Categorie(ItalyViewModel italyViewModel)
        {
            italyViewModel.categories = new Categories();
            var model = italyViewModel.categories.categories.Where(x => x.Name == italyViewModel.categorieName ||
                                                                                   x.NameArm == italyViewModel.categorieName ||
                                                                                   x.NameRus == italyViewModel.categorieName).FirstOrDefault();
            model.isQR = italyViewModel.isQR;
            return View("categorie", model);
        }
        public IActionResult CategorieArm(ItalyViewModel italyViewModel)
        {
            italyViewModel.categories = new Categories();
            var model = italyViewModel.categories.categories.Where(x => x.Name == italyViewModel.categorieName ||
                                                                                   x.NameArm == italyViewModel.categorieName ||
                                                                                   x.NameRus == italyViewModel.categorieName).FirstOrDefault();
            model.isQR = italyViewModel.isQR;
            return View("categorie_arm", model);
        }
        public IActionResult CategorieRus(ItalyViewModel italyViewModel)
        {
            italyViewModel.categories = new Categories();
            var model = italyViewModel.categories.categories.Where(x => x.Name == italyViewModel.categorieName ||
                                                                                   x.NameArm == italyViewModel.categorieName ||
                                                                                   x.NameRus == italyViewModel.categorieName).FirstOrDefault();
            model.isQR = italyViewModel.isQR;
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
