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
                Id = Guid.NewGuid().ToString(),
                FoundationYear = 1970
            };

            ViewBag.SomethingStrange = "This comes from controller";
            return View(school);
        }
    }
}