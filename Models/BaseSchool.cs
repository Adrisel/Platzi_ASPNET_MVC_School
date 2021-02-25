using System;
namespace SchoolMVC.Models
{
    public abstract class BaseSchool
    {
        //This is virtual because can be override for derived classes
        public virtual string Name { get; set; }
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