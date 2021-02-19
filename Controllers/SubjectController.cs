using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers
{
    public class SubjectController : Controller
    {
        private SchoolContext _context;
        public SubjectController(SchoolContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Date = DateTime.Now;
            return View(_context.Subject.First());
        }

        public IActionResult MultipleSubject()
        {
            return View(_context.Subject.ToList());
        }
    }
}