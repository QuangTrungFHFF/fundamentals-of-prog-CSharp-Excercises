using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise22
{
    /// <summary>
    /// Disciplines have a name, number of lessons and number of exercises
    /// </summary>
    class Discipline
    {
        public string DisciplineName { get; set; }
        public int NumberOfLessons { get; set; }
        public int NumberOfExercises { get; set; }
        public Discipline(string disciplineName, int numberOfLessons,int numberOfExercises)
        {
            DisciplineName = disciplineName;
            NumberOfLessons = numberOfLessons;
            NumberOfExercises = numberOfExercises;
        }
        public Discipline(string disciplineName) :this(disciplineName,0,0)
        {
        }
        public Discipline(): this("Unnamed")
        {

        }
    }
}
