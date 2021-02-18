using System;
using System.Collections.Generic;
using System.Linq;
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
             List<Student> studentList = GenerateStudents(30);
            return View(studentList);
        }

    }
}