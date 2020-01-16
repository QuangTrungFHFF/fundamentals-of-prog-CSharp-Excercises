using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Exercise03
{
    class Student : Human,IComparable<Student>
    {
        public string Name { get { return string.Format($"{FirstName} {LastName}"); } }
        public double Mark { get; set; }
        public Student(string firstName,string lastName, double mark) : base(firstName,lastName)
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
            return string.Format($"Name - {Name.PadRight(15)} | Mark - {Mark:N2}");
        }

        public int CompareTo([AllowNull] Student other)
        {
            if (other == null)
                return -1;
            return this.Mark.CompareTo(other.Mark);
        }
    }
}
