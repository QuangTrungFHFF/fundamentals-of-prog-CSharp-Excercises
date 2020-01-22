using StudentLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FindStudentWithGivenAgeRange
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var students = new List<Student>() { new Student("Fredrick", "Conley", 16), new Student("Barack", "Obama", 26), new Student("Tyra", "Tang", 17),
               new Student("Aliesha", "Pittman", 16), new Student("Charley", "Shannon", 26), new Student("Zaria", "Toby", 18),new Student("Abby", "Martin", 19),
               new Student("Neil", "Krueger", 26), new Student("Alexandru", "Glass", 17), new Student("Connie", "Boyce", 20), new Student("Reegan", "Forster", 26)};
            var studentWithAgeFrom18To24 = students.Where(s => (s.Age > 18 && s.Age < 24)).ToList();
            foreach (Student s in studentWithAgeFrom18To24)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}