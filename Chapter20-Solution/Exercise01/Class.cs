using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    class Class
    {
        public string ClassID { get; private set; }
        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }
        public Class(string classID)
        {
            this.ClassID = classID;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }
        public void AddStudent(string firstName, string lastName, int studentID)
        {
            var student = new Student(firstName, lastName, studentID);
            if(this.Students.)
        }
    }
}
