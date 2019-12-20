using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise22
{
    /// <summary>
    /// Each teacher has a variety of disciplines taught
    /// </summary>
    class Teacher
    {        
        public string TeacherName { get; set; }
        public List<Discipline> Disciplines { get; set; }
        public Teacher(string teacherName, List<Discipline> disciplines)
        {
            TeacherName = teacherName;
            Disciplines = disciplines;
        }
        public Teacher(string teacherName)
        {
            TeacherName = teacherName;
            Disciplines = new List<Discipline>();
        }

        // Add new Discipline
        public void AddDiscipline(string name, int numberOfLessons, int numberOfExercises)
        {
            Disciplines.Add(new Discipline(name, numberOfLessons, numberOfExercises));
        }
        public void AddDiscipline(string name)
        {
            Disciplines.Add(new Discipline(name));
        }
    }
}
