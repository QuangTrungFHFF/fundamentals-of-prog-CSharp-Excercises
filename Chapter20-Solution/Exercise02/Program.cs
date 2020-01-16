using System;

namespace Exercise02
{
    /// <summary>
    /// Define a class Human with properties "first name" and "last name". Define the class Student inheriting Human, which has the property "mark".
    /// Define the class Worker inheriting Human with the property "wage" and "hours worked".
    /// Implement a "calculate hourly wage" method, which calculates a worker’s hourly pay rate based on wage and hours worked.
    /// Write the corresponding constructors and encapsulate all data in properties.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("John", "Lenon", 3600, 120);
            worker.PrintHourlyPayRate();
        }
    }
}
