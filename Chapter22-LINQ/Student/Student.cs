using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Student
{
    public class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public int CompareTo([AllowNull] Student other)
        {
            if(this.FirstName.CompareTo(other.FirstName)==0)
            {
                if (this.LastName.CompareTo(other.LastName) == 0)
                {
                    return this.Age.CompareTo(other.Age);
                }
                return this.LastName.CompareTo(other.LastName);
            }
            return this.FirstName.CompareTo(other.FirstName);
        }
        public override bool Equals(object obj)
        {
            var that = (Student)obj;
            int a = this.FirstName.CompareTo(that.FirstName);
            int b = this.LastName.CompareTo(that.LastName);
            int c = this.Age.CompareTo(that.Age);
            return (a*b*c ==0);
        }

        public override int GetHashCode()
        {
            int hash = this.FirstName.GetHashCode();
            hash += this.LastName.GetHashCode() * 2;
            hash += this.Age.GetHashCode() * 3;
            return hash;
        }
    }
} 