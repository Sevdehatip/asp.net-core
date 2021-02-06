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

        [HttpGet]
        public IActionResult NewDepartman()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewDepartman(department d)
        {
            context.departments.Add(d);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult RemoveDepartment(int id)
        {
            var dep = context.departments.Find(id);
            context.departments.Remove(dep);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult GetDepartment(int id)
        {
            var deps = context.departments.Find(id);
            return View("GetDepartment", deps);
        }

        public IActionResult UpdateDepartment(department d)
        {
            var dep = context.departments.Find(d.id);
            dep.departmentName = d.departmentName;
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
