using System;
using System.Collections.Generic;

namespace SchoolMVC.Models
{

    public class Course : BaseSchool
    {
        //first step to declare and event vit event handler
        public event EventHandler StudentAddedProcessCompleted;
        public TurnType TurnType { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }
        public string Address { get; set; }
        public string SchoolId { get; set; }
        public School School { get; set; }

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