using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers
{
    public class CourseController : Controller
    {
        private SchoolContext _context;
        public CourseController(SchoolContext context)
        {
            _context = context;
        }
        public IActionResult Index(string id)
        {
             if(!string.IsNullOrWhiteSpace(id))
            {
                var course = _context.Courses.FirstOrDefault(x => x.Id == id);
                ViewBag.Date = DateTime.Now;
                return View(course);
            }
            else 
            {
                return View("MultipleCourse", _context.Courses.ToList());
            }
        }

        public IActionResult MultipleCourse()
        {
            return View(_context.Courses.ToList());
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            var school = _context.Schools.FirstOrDefault();
            course.SchoolId = school.Id;
            _context.Courses.Add(course);
            _context.SaveChanges();
            return View();
        }
    }
}