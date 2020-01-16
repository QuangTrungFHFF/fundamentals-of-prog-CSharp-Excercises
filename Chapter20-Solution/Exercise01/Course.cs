using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    class Course
    {
        public string Name { get; private set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExams { get; set; }
        public Course(string name, int lectures, int exams)
        {
            this.Name = name;
            this.NumberOfLectures = lectures;
            this.NumberOfExams = exams;
        }
        public Course(string name):this(name,0,0)
        {

        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
