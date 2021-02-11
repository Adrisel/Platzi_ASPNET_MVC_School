using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student() { Name = "Adriana Selena" };

            ViewBag.Date = DateTime.Now;
            return View(student);
        }

        public IActionResult MultipleStudent()
        {
             List<Student> studentList = new List<Student>()
                {
                    new Student(){Name = "Carla"},
                    new Student(){Name = "Rudy"},
                    new Student(){Name = "Rafael"},
                    new Student(){Name = "Isabel"},

                };
            return View(studentList);
        }
    }
}