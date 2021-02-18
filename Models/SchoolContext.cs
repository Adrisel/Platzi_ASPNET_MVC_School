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
            modelBuilder.Entity<School>().HasData(school);

            List<Subject> subjectList = new List<Subject>()
            {
                new Subject(){Name = "Maths"},
                new Subject(){Name = "Spanish"},
                new Subject(){Name = "Science"},
                new Subject(){Name = "Sports"},
            };
            modelBuilder.Entity<Subject>().HasData(subjectList.ToArray());

            modelBuilder.Entity<Student>().HasData(GenerateStudents(20).ToArray());
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