using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers
{
    public class SchoolController : Controller
    {
        private SchoolContext _context;
        public SchoolController(SchoolContext context)
        {
            _context = context;
        }
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
            var temp = _context.Schools.FirstOrDefault();
            ViewBag.SomethingStrange = "This comes from controller";
            return View(school);
        }
    }
}