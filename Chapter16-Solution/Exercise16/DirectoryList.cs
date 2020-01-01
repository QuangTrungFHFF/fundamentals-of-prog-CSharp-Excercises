using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise16
{
    /// <summary>
    /// Using queue, implement a complete traversal of all directories on your hard disk and print them on the console.
    /// Implement the algorithm Breadth-First-Search (BFS) – you may find some articles in the internet.
    /// </summary>
    internal class DirectoryList
    {
        private static void Main(string[] args)
        {
            Queue<string> directories = new Queue<string>();
            Console.WriteLine("Print all sub directory!");
            string[] dir;
            string currentdir = @"D:\";
            directories.Enqueue(currentdir);
            while (directories.Count > 0)
            {
                currentdir = directories.Dequeue();
                Console.WriteLine(currentdir);
                try
                {
                    dir = Directory.GetDirectories(currentdir);
                    foreach (string s in dir)
                    {
                        directories.Enqueue(s);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
            }
        }
    }
}