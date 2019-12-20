using System;
using System.Collections.Generic;
/// <summary>
/// We have a school. In school we have classes and students. Each class has a number of teachers. Each teacher has a variety of disciplines taught. 
/// Students have a name and a unique number in the class. Classes have a unique text identifier. Disciplines have a name, number of lessons and number of exercises. 
/// The task is to shape a school with C# classes.
/// You have to define classes with their fields, properties, methods and constructors. Also define a test class, which demonstrates, that the other classes work correctly.
/// </summary>
namespace Exercise22
{
    class TestClass
    {
        static void Main(string[] args)
        {
            //Add Class
            Class masterITClass = new Class("Master-IT");
            //Add new list of disciplines
            List<Discipline> disList = new List<Discipline>();
            disList.Add(new Discipline("Mathematics", 12, 48));
            disList.Add(new Discipline("Physics"));
            //Add teacher to the class
            masterITClass.AddTeacher(new Teacher("Peter Nauth",disList));
            //Add students to the class
            masterITClass.AddStudent("Tran Quang Trung", "1068177");
            masterITClass.AddStudent("Tran Thi Bich Ngoc", "1724512");
            Console.WriteLine("Complete!");
        }
        
    }
}
