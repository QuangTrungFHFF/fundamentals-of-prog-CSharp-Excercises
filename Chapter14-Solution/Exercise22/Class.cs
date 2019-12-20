using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise22
{
    /// <summary>
    /// Each class has a number of teachers and students.
    /// </summary>
    class Class
    {
        public string ClassID { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
        public Class(string classID,List<Teacher> teachers, List<Student> students)
        {
            ClassID = classID;
            Teachers = teachers;
            Students = students;
        }
        public Class(string classID)
        {
            ClassID = classID;
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }

        /// <summary>
        /// Add new student
        /// </summary>
        /// <param name="name"></param>
        /// <param name="studentID"></param>
        public void AddStudent(string name, string studentID)
        {
            Students.Add(new Student(name, studentID));
        }

        /// <summary>
        /// Add new teacher
        /// </summary>
        /// <param name="teacher"></param>
        public void AddTeacher(Teacher teacher )
        {
            Teachers.Add(teacher);
        }
        public void AddTeacher(string teacherName)
        {
            Teachers.Add(new Teacher(teacherName);
        }

    }
}
