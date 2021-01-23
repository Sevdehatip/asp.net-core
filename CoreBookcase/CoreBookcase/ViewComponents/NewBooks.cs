using CoreBookcase.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBookcase.ViewComponents
{
    public class NewBooks:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var bookList = new List<Books>
            {
                new Books
                {
                    ID=6,
                    BookName="Korku",
                    Author="Zweig"
                },
                new Books
                {
                    ID=7,
                    BookName="Anna",
                    Author="Tolstoy"
                }
            };
            return View(bookList);
        }
    }
}
