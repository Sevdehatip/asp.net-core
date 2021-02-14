using CoreDepartmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDepartmentApp.Controllers
{
    public class employeeController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.employees.Include(x => x.department).ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult NewEmployee()
        {
            List<SelectListItem> value = (from x in c.departments.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.departmentName,
                                              Value = x.id.ToString()
                                          }).ToList();
            ViewBag.vl = value;
            return View();
        }

        public IActionResult NewEmployee(employee e)
        {
            var per = c.departments.Where(x => x.id == e.department.id).FirstOrDefault();
            e.department = per;
            c.employees.Add(e);
            c.SaveChanges();
            return View("Index");
        }

    }
}
