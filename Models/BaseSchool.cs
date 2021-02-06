using System;
namespace SchoolMVC.Models
{
    public abstract class BaseSchool
    {
        public string Name { get; set; }
        public string  Id { get; private set; }
        public BaseSchool()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Name}, {Id}";
        }
    }
}