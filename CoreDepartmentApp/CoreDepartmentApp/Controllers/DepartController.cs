using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDepartmentApp.Models;

namespace CoreDepartmentApp.Controllers
{
    public class DepartController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var degerler = context.departments.ToList();
            return View(degerler);
        }
    }
}
