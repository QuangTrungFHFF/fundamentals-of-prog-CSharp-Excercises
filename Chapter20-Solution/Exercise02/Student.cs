using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02
{
    class Student : Human
    {
        public string Name { get { return string.Format($"{FirstName} {LastName}"); } }
        public double Mark { get; set; }
        public Student(string firstName,string lastName, int mark) : base(firstName,lastName)
        {
            this.Mark = mark;            
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            var that = (Student)obj;
            if (this.GetHashCode() == that.GetHashCode())
                return true;
            return false;

        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Mark.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format($"Name - {Name.PadLeft(25)} | Mark - {Mark:N2}");
        }
    }
}
