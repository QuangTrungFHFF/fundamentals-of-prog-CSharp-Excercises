using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise17
{
    /// <summary>
    /// Using stack, implement a complete traversal of all directories on your hard disk and print them on the console.
    /// Implement the algorithm Depth-First-Search (DFS) – you may find some articles in the internet.
    /// </summary>
    internal class DFSDirectories
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Print all sub-directories using DFS!");
            string currentDirectory = @"D:\";
            var directories = new Stack<string>();
            string[] subDirectories;
            directories.Push(currentDirectory);
            while (directories.Count > 0)
            {
                currentDirectory = directories.Pop();
                Console.WriteLine(currentDirectory);
                try
                {
                    subDirectories = Directory.GetDirectories(currentDirectory);
                    foreach (string s in subDirectories)
                    {
                        directories.Push(s);
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