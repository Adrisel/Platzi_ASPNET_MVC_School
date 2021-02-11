using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            var subject = new Subject() { Name = "Music" };

            ViewBag.Date = DateTime.Now;
            return View(subject);
        }

        public IActionResult MultipleSubject()
        {
             List<Subject> subjectList = new List<Subject>()
                {
                    new Subject(){Name = "Maths"},
                    new Subject(){Name = "Spanish"},
                    new Subject(){Name = "Science"},
                    new Subject(){Name = "Sports"},

                };
            return View(subjectList);
        }
    }
}