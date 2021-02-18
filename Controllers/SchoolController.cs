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
            var temp = _context.Schools.FirstOrDefault();
            ViewBag.SomethingStrange = "This comes from controller";
            return View(school);
        }
    }
}