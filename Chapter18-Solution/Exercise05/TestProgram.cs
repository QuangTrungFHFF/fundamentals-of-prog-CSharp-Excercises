using System;

namespace Exercise05
{
    internal class TestProgram
    {
        private static void Main(string[] args)
        {
            //Create a new Double Key Dictionary
            DoubleKeyDictionary<string, int, double> classRoom = new DoubleKeyDictionary<string, int, double>();
            classRoom.Add("Mary Barra", 16, 2.2);
            classRoom.Add("Vladimir Putin", 19, 3.2);
            classRoom.Add("Bill Gates", 18, 1.2);
            classRoom.Add("Steven Jobs", 16, 2.2);
            classRoom.Add("Angela Merkel", 15, 1.7);
            classRoom.Add("Barack Obama", 16, 1.9);
            //Print to the console
            Console.WriteLine("There are {0} student(s) in the class.", classRoom.Count);
            foreach (var student in classRoom)
            {
                Console.WriteLine("Name: {0} - Age: {1} - Score: {2}", student.Item1, student.Item2, student.Item3);
            }
            //Try adding an already exist pair of keys
            classRoom.Add("Angela Merkel", 15, 4.0);
            //Test remove function
            classRoom.Remove("Angela Merkel", 15);
            classRoom.Remove("Angela Merkel", 19);
            //Print to the console
            foreach (var student in classRoom)
            {
                Console.WriteLine("Name: {0} - Age: {1} - Score: {2}", student.Item1, student.Item2, student.Item3);
            }
            //Test TryGetValue function
            double score;
            if (classRoom.TryGetValue("Barack Obama", 16, out score))
            {
                Console.WriteLine("Score: " + score);
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }
    }
}