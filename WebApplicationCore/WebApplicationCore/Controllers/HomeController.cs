using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Models;

namespace WebApplicationCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            var Kitaplar = new List<Kitap>()
            {
                new Kitap() { ID=1, KitapAd="AAAAA", Yazar="Jules Verne"},
                new Kitap() { ID=2, KitapAd="BBBBB", Yazar="Zweig"},
                new Kitap() { ID=3, KitapAd="CCCCC", Yazar="Charles"}
            };
            return View(Kitaplar);
        }

        public IActionResult Index4()
        {
            ViewBag.deger1 = "Core working";
            ViewBag.deger2 = "Core studying";
            return View();
        }
        public IActionResult Index5()
        {
            return View();
        }
        public IActionResult Index6()
        {
            return View();
        }
        public IActionResult Index7()
        {
            return View();
        }
    }
}
