using System;

namespace SchoolMVC.Models
{    
    public class Subject : BaseSchool
    {
        public string CourseId { get; set; }
        public Course Course { get; set; }
        public List<Test> Tests { get; set; }
    }
}