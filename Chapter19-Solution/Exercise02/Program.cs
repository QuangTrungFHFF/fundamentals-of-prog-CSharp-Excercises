using System;

namespace Exercise02
{
    /// <summary>
    /// Implement a data structure, which can quickly do the following two operations: add an element and extract the smallest element.
    /// The structure should accept adding duplicated elements.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ListWithMin<int>(125);
            list.Add(24);
            list.Add(78);
            list.Add(25);
            list.Add(36);
            list.Add(78);
            list.Add(965);
            Console.WriteLine("Min element is: {0}", list.Min);
        }
    }
}
