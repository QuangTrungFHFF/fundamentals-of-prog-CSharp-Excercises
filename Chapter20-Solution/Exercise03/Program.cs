using System;
using System.Collections.Generic;

namespace Exercise03
{
    /// <summary>
    /// Initialize an array of 10 students and sort them by mark in ascending order. Use the interface System.IComparable<T>.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Mary", "Oma1", 9));
            students.Add(new Student("Mary", "Oma2", 2));
            students.Add(new Student("Mary", "Oma3", 4));
            students.Add(new Student("Mary", "Oma4", 6.2));
            students.Add(new Student("Mary", "Oma5", 3.5));
            students.Add(new Student("Mary", "Oma6", 7.2));
            students.Add(new Student("Mary", "Oma7", 9.6));
            students.Add(new Student("Mary", "Oma8", 7.5));
            students.Add(new Student("Mary", "Oma9", 8.3));
            students.Add(new Student("Mary", "OmaX", 5.5));
            students.Sort();
            foreach(var s in students)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
