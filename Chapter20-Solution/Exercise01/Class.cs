using System;
using System.Collections.Generic;

namespace Exercise01
{
    internal class Class
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
            if (this.Students.Contains(student))
            {
                Console.WriteLine("There's a student in the class with same Student ID!");
            }
            else
            {
                this.Students.Add(student);
            }
        }

        public void AddTeacher(string firstName, string lastName)
        {
            var teacher = new Teacher(firstName, lastName);

            this.Teachers.Add(teacher);
        }
        public void RemoveStudent(Student student)
        {
            if (!this.Students.Contains(student))
            {
                Console.WriteLine($"Cannot find the student with given Student ID: {student.StudentID}!");
            }
            else
            {
                this.Students.Remove(student);
            }
        }
        public void RemoveTeacher(Teacher teacher)
        {
            if (!this.Teachers.Contains(teacher))
            {
                Console.WriteLine($"Cannot find the teacher with name: {teacher.Name}!");
            }
            else
            {
                this.Teachers.Remove(teacher);
            }
        }
        public void PrintStudentsList()
        {
            Console.WriteLine($"Class: {this.ClassID}");
            foreach(var s in this.Students)
            {
                Console.WriteLine(s.ToString());
            }
        }
        public void PrintTeachersList()
        {
            Console.WriteLine($"Class: {this.ClassID}");
            foreach (var t in this.Teachers)
            {
                Console.WriteLine(t.ToString());
            }
        }
        public override string ToString()
        {
            return this.ClassID;
        }

    }
}
