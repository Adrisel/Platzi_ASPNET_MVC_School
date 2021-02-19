using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext _context;
        public StudentController(SchoolContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Date = DateTime.Now;
            return View(_context.Students.FirstOrDefault());
        }

        public IActionResult MultipleStudent()
        {
            return View(_context.Students.ToList());
        }
    }
}