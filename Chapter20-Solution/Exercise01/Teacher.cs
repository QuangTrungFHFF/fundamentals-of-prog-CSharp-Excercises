using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    class Teacher : People
    {
        public string Name { get { return string.Format($"{FirstName} {LastName}"); } }
        public HashSet<Course> Courses { get; private set; }
        public Teacher(string firstName, string lastName) : base(firstName,lastName)
        {
            this.Courses = new HashSet<Course>();
        }
        public void AddCourses(params Course[] courses)
        {
            foreach (var c in courses)
            {
                this.Courses.Add(c);
            }
        }
        public void RemoveCourse(Course course)
        {
            this.Courses.Remove(course);
        }
        public override string ToString()
        {
            return string.Format($"Name: {Name.PadLeft(25)}");
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            var that = (Teacher)obj;
            return this.Name.Equals(that.Name);
        }

        public override int GetHashCode()
        {
            int hash = this.Name.GetHashCode();
            return hash;
        }
    }
}
