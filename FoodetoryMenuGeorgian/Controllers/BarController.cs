﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Categorie(BarViewModel barViewModel)
        {
            barViewModel.categories = new Categories();
            return View("categorie", barViewModel.categories.categories.Where(x => x.Name == barViewModel.categorieName ||
                                                                                   x.NameArm == barViewModel.categorieName ||
                                                                                   x.NameRus == barViewModel.categorieName).FirstOrDefault());
        }
        public IActionResult CategorieArm(BarViewModel barViewModel)
        {
            barViewModel.categories = new Categories();
            return View("categorie_arm", barViewModel.categories.categories.Where(x => x.Name == barViewModel.categorieName ||
                                                                                   x.NameArm == barViewModel.categorieName ||
                                                                                   x.NameRus == barViewModel.categorieName).FirstOrDefault());
        }
        public IActionResult CategorieRus(BarViewModel barViewModel)
        {
            barViewModel.categories = new Categories();
            return View("categorie_rus", barViewModel.categories.categories.Where(x => x.Name == barViewModel.categorieName ||
                                                                                   x.NameArm == barViewModel.categorieName ||
                                                                                   x.NameRus == barViewModel.categorieName).FirstOrDefault());
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
            }
            if (sushiViewModel.Lang == "Arm")
            {
                sushiViewModel.NameAndPrice = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                                           x.NameArm == sushiViewModel.MenuName ||
                                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Name == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameArm == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameRus == sushiViewModel.NameAndPrice).FirstOrDefault().NameArm;
            }
            if (sushiViewModel.Lang == "Rus")
            {
                sushiViewModel.NameAndPrice = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                                           x.NameArm == sushiViewModel.MenuName ||
                                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Name == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameArm == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameRus == sushiViewModel.NameAndPrice).FirstOrDefault().NameRus;
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
