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
        public IActionResult Index(string id)
        {
             if(!string.IsNullOrWhiteSpace(id))
            {
                var student = _context.Students.FirstOrDefault(x => x.Id == id);
                ViewBag.Date = DateTime.Now;
                return View(student);
            }
            else 
            {
                return View("MultipleStudent", _context.Students.ToList());
            }
        }

        public IActionResult MultipleStudent()
        {
            return View(_context.Students.ToList());
        }
    }
}