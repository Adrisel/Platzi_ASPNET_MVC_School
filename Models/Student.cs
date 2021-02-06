using System.Collections.Generic;

namespace SchoolMVC.Models
{
    
    public class Student : BaseSchool
    {
        public List<Test> Tests { get; set; }
    }
}