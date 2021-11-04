using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodetoryMenuGeorgian.Models.Georgian;

namespace FoodetoryMenuGeorgian.Controllers
{
    public class GeorgianController : Controller
    {
        [Route("/Georgian")]
        public IActionResult Georgian()
        {
            GeorgianViewModel barViewModel = new GeorgianViewModel() { categories = new Categories()};
            return View("georgian", barViewModel);
        }
        [Route("/Georgian_arm")]
        public IActionResult GeorgianArm()
        {
            GeorgianViewModel barViewModel = new GeorgianViewModel() { categories = new Categories() };
            return View("georgian_arm", barViewModel);
        }
        [Route("/Georgian_rus")]
        public IActionResult GeorgianRus()
        {
            GeorgianViewModel barViewModel = new GeorgianViewModel() { categories = new Categories() };
            return View("georgian_rus", barViewModel);
        }
        public IActionResult Categorie(GeorgianViewModel barViewModel)
        {
            barViewModel.categories = new Categories();
            return View("categorie", barViewModel.categories.categories.Where(x => x.Name == barViewModel.categorieName ||
                                                                                   x.NameArm == barViewModel.categorieName ||
                                                                                   x.NameRus == barViewModel.categorieName).FirstOrDefault());
        }
        public IActionResult CategorieArm(GeorgianViewModel barViewModel)
        {
            barViewModel.categories = new Categories();
            return View("categorie_arm", barViewModel.categories.categories.Where(x => x.Name == barViewModel.categorieName ||
                                                                                   x.NameArm == barViewModel.categorieName ||
                                                                                   x.NameRus == barViewModel.categorieName).FirstOrDefault());
        }
        public IActionResult CategorieRus(GeorgianViewModel barViewModel)
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
                sushiViewModel.Description = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                                           x.NameArm == sushiViewModel.MenuName ||
                                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Description == sushiViewModel.Description ||
                                                                                                                                                   x.DescriptionArm == sushiViewModel.Description ||
                                                                                                                                                   x.DescriptionRus == sushiViewModel.Description).FirstOrDefault().Description;
            }
            if (sushiViewModel.Lang == "Arm")
            {
                sushiViewModel.NameAndPrice = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                                           x.NameArm == sushiViewModel.MenuName ||
                                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Name == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameArm == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameRus == sushiViewModel.NameAndPrice).FirstOrDefault().NameArm;
                sushiViewModel.Description = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                           x.NameArm == sushiViewModel.MenuName ||
                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Description == sushiViewModel.Description ||
                                                                                                                                   x.DescriptionArm == sushiViewModel.Description ||
                                                                                                                                   x.DescriptionRus == sushiViewModel.Description).FirstOrDefault().DescriptionArm;

            }
            if (sushiViewModel.Lang == "Rus")
            {
                sushiViewModel.NameAndPrice = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                                           x.NameArm == sushiViewModel.MenuName ||
                                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Name == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameArm == sushiViewModel.NameAndPrice ||
                                                                                                                                                   x.NameRus == sushiViewModel.NameAndPrice).FirstOrDefault().NameRus;
                sushiViewModel.Description = categories.categories.Where(x => x.Name == sushiViewModel.MenuName ||
                                                           x.NameArm == sushiViewModel.MenuName ||
                                                           x.NameRus == sushiViewModel.MenuName).FirstOrDefault().Products.Where(x => x.Description == sushiViewModel.Description ||
                                                                                                                                   x.DescriptionArm == sushiViewModel.Description ||
                                                                                                                                   x.DescriptionRus == sushiViewModel.Description).FirstOrDefault().DescriptionRus;

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
