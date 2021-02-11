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

         private List<Student> GenerateStudents(int quantity)
        {
            string[] name1 = new string[] { "Adriana", "Marcia", "Ronald", "Mauricio", "Daniel" };
            string[] name2 = new string[] { "Tito", "Camacho", "Sanchez", "Salazar", "Orellana" };

            var studentsList = from n1 in name1
                               from n2 in name2
                               select new Student() { Name = $"{n1} {n2}" };
            return studentsList.OrderBy(std => std.Id).Take(quantity).ToList();
        }
    }
}