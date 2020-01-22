using System;
using System.Collections.Generic;
using StudentLib;
using System.Linq;

namespace StudentsSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>() { new Student("Fredrick", "Conley", 16), new Student("Barack", "Obama", 26), new Student("Tyra", "Tang", 17),
               new Student("Aliesha", "Pittman", 16), new Student("Charley", "Shannon", 26), new Student("Zaria", "Toby", 18),new Student("Abby", "Martin", 19),
               new Student("Neil", "Krueger", 26), new Student("Alexandru", "Glass", 17), new Student("Connie", "Boyce", 20), new Student("Reegan", "Forster", 26)};

            var sortedStudentList = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName).ToList();
            foreach (var s in sortedStudentList)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("-------------------------");

            var sortedStudentListByLinq = from student in students
                                          orderby student.FirstName descending, student.LastName descending
                                          select student;

            foreach (var s in sortedStudentListByLinq)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
