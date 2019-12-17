using System;
using System.Collections.Generic;

/// <summary>
/// Write a class StudentTest, which has to test the functionality of the class Student.
/// </summary>
namespace Exercise06
{
    internal class StudentTest
    {
        private static List<Student> studentList = new List<Student>();

        private static void Main(string[] args)
        {
            Console.WriteLine("Press enter to begin test!");
            Console.ReadLine();
            AddStudent();
            Console.WriteLine("Test success!");
        }
        /// <summary>
        /// Add 3 new students 
        /// </summary>
        public static void AddStudent()
        {
            List<string> names = new List<string>() { "Jimmy Wood", "Toby Thomas", "Maximus Martin" };
            List<int> courses = new List<int>() { 3, 2, 1 };
            List<string> subjects = new List<string>() { "c#", "Java", "Python" };
            List<string> universities = new List<string>() { "Ludwig Maximilian University of Munich", "Heidelberg  University", "Humboldt University of Berlin" };
            List<string> emails = new List<string>() { "tata521ta@xmail.com", "bibobiba@superhotmail.com", "maximaluma@yahuu.com" };
            List<string> phoneNumbers = new List<string>() { "015728956324", "0908745214", "012745632145" };
            for (int i = 0; i < 3; i++)
            {
                StudentTest.studentList.Add(new Student(names[i], courses[i], subjects[i], universities[i], emails[i], phoneNumbers[i]));
            }
            Console.WriteLine("3 students added!");
        }
    }
}