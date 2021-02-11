using System;
using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            School school = new School()
            {
                Name = "Maria Inmaculada",
                Country = "Bolivia",
                City = "La Paz",
                Address = "Av. Armentia",
                SchoolType = SchoolType.Elementary,
                YearFoundation = 1970
            };

            ViewBag.SomethingStrange = "This comes from controller";
            return View(school);
        }
    }
}