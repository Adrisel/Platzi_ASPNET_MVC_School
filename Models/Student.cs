using System.Collections.Generic;

namespace SchoolMVC.Models
{

    public class Student : BaseSchool
    {
        public List<Test> Tests { get; set; }
        public string CourseId { get; set; }
        public Course Course { get; set; }
    }
}