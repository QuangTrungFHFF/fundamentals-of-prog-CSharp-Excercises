using System;
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

            Console.WriteLine("Hello World!");
        }
        
    }
}
