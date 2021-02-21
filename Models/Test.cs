using System;

namespace SchoolMVC.Models
{
    
    public class Test :BaseSchool
    {
        public string StudentId { get; set; }
        public Student Student { get; set; }
        public string SubjectId { get; set; }
        public Subject Subject { get; set; }
        public float Score { get; set; }

        public override string ToString()
        {
            return $"{Subject.Name}, {Student.Name}, {Score}";
        }
    }
}