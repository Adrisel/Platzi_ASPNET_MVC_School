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
    }
}