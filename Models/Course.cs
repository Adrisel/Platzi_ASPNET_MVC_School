using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolMVC.Models
{

    public class Course : BaseSchool
    {
        //first step to declare and event vit event handler
        public event EventHandler StudentAddedProcessCompleted;
        public TurnType TurnType { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }
        [Required(ErrorMessage = "The Address is required")]
        [StringLength(12, ErrorMessage = "Address should be more than 12 characters")]
        public string Address { get; set; }
        public string SchoolId { get; set; }
        public School School { get; set; }
        
        [Required(ErrorMessage = "The course name is required")]
        [MinLength(5, ErrorMessage = "The name should be less than 5 characters")]
        public override string Name { get; set; }

        public void CleanPlace()
        {
            System.Console.WriteLine($"Course {Name} Cleaned");
        }

        public void AddStudent(string name)
        {
            Students.Add(new Student() { Name = name, Tests = new List<Test>() });
            ///I want to notify that a user was added
            OnProcessCompleted(EventArgs.Empty);
        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            //Invoke the event and some class can suscribe to this event in this case School
            StudentAddedProcessCompleted?.Invoke(this, e);
        }
    }
}