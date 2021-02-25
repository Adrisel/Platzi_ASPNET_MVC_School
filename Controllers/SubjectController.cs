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

        //[Route("Subject/Index")]
        [Route("Subject/Index/{subjectId?}")]
        public IActionResult Index(string subjectId)
        {
            if(!string.IsNullOrWhiteSpace(subjectId))
            {
                var subject = _context.Subject.FirstOrDefault(x => x.Id == subjectId);
                ViewBag.Date = DateTime.Now;
                return View(subject);
            }
            else 
            {
                return View("MultipleSubject", _context.Subject.ToList());
            }
        }

        public IActionResult MultipleSubject()
        {
            return View(_context.Subject.ToList());
        }
    }
}