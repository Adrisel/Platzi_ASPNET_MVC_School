using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SchoolMVC.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            School school = new School()
            {
                Name = "Maria Inmaculada",
                Country = "Bolivia",
                City = "La Paz",
                Address = "Av. Armentia",
                SchoolType = SchoolType.Elementary,
                YearFoundation = 1970
            };

            //Cargar cursos de la escuela
            var courses = AddCourses(school);
            //x cada curso cargar asignaturas
            var subjects = AddSubject(courses); 
            // x cada curso cargar alumnos
            var students = AddStudents(courses);

            modelBuilder.Entity<School>().HasData(school);
            modelBuilder.Entity<Course>().HasData(courses.ToArray());
            modelBuilder.Entity<Subject>().HasData(subjects.ToArray());
            modelBuilder.Entity<Student>().HasData(students.ToArray());
        }

        private List<Course> AddCourses(School school)
        {
            return new List<Course>
            {
               new Course(){ Name = "101",TurnType = TurnType.Morning, SchoolId = school.Id},
               new Course(){ Name = "201",TurnType = TurnType.Morning, SchoolId = school.Id},
               new Course(){ Name = "301",TurnType = TurnType.Morning, SchoolId = school.Id},
               new Course(){ Name = "401",TurnType = TurnType.Morning, SchoolId = school.Id},
               new Course(){ Name = "501",TurnType = TurnType.Morning, SchoolId = school.Id}
            };
        }

        private List<Subject> AddSubject(List<Course> courses)
        {
            List<Subject> completeList = new List<Subject>();
            foreach (var course in courses)
            {
                var tempList = new List<Subject>()
                {
                    new Subject(){Name = "Maths", CourseId = course.Id},
                    new Subject(){Name = "Spanish", CourseId = course.Id},
                    new Subject(){Name = "Science", CourseId = course.Id},
                    new Subject(){Name = "Sports", CourseId = course.Id},
                };

                completeList.AddRange(tempList);
            }
            return completeList;
        }

        private List<Student> GenerateStudents(int quantity, Course course)
        {
            string[] name1 = new string[] { "Adriana", "Marcia", "Ronald", "Mauricio", "Daniel" };
            string[] name2 = new string[] { "Tito", "Camacho", "Sanchez", "Salazar", "Orellana" };

            var studentsList = from n1 in name1
                               from n2 in name2
                               select new Student() { Name = $"{n1} {n2}" , CourseId = course.Id};
            return studentsList.OrderBy(std => std.Id).Take(quantity).ToList();
        }

         private List<Student> AddStudents(List<Course> courses)
        {
            Random random = new Random();
            var studentList = new List<Student>();
            foreach (var course in courses)
            {
                int numeberOfStudent = random.Next(5, 20);
                var tempList = GenerateStudents(numeberOfStudent, course);
                studentList.AddRange(tempList);
            }
            return studentList;
        }
    }
}