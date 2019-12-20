using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise22
{
    /// <summary>
    /// Students have a name and a unique number in the class
    /// </summary>
    class Student
    {
        public string StudentName { get; set; }
        public string StudentID { get; set; }
        public Student(string name, string iD)
        {
            StudentName = name;
            StudentID = iD;
        }

    }
}
