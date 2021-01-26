using CoreBookcase.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBookcase.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var book = new List<Books>()
            {
                new Books(){ID=1, BookName="Satranç", Author="Zweig"},
                new Books(){ID=2, BookName="xxxx", Author="YYY"},
                new Books(){ID=3, BookName="Yaşam", Author="kdfjdkf"},
                new Books(){ID=4, BookName="İnsanlık", Author="Ray"},
                new Books(){ID=5, BookName="Umut", Author="Cey"},
            };
            return View(book);
        }
        public IActionResult Deneme()
        {
            return View();
        }
        public IActionResult StaticTheme()
        {
            return View();
        }
    }
}
