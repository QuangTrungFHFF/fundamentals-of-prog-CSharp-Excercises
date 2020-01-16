using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    class Student : People
    {
        public int StudentID { get; private set; }
        public string Name { get { return string.Format($"{FirstName} {LastName}"); } }
        public Student(string firstName,string lastName,int? age, int studentID) : base(firstName,lastName,age)
        {
            this.StudentID = studentID;
        }
        public Student(string firstName, string lastName, int studentID) :this(firstName,lastName,null,studentID)
        {

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
            return StudentID.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format($"Student: ID - {StudentID.ToString().PadLeft(12)} | Name - {Name.PadLeft(25)} | Age - {this.Age} ");
        }
    }
}
