using CoreDepartmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartmentApp.Controllers
{
    public class employeeController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.employees.ToList();
            return View(degerler);
        }
    }
}
