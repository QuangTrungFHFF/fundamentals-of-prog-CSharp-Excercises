using System;
using System.Collections.Generic;

namespace Exercise02
{
    /// <summary>
    /// Write a program, which reads from the console N integers and prints them in reversed order. Use the Stack<int> class.
    /// </summary>
    internal class ReverseStack
    {
        private static void Main(string[] args)
        {
            string input;
            int n;
            int num;
            var stack = new Stack<int>();
            Console.WriteLine("Please input N!");
            input = Console.ReadLine();
            while (!int.TryParse(input, out n))
            {
                Console.WriteLine("Invalid input. Please input N!");
                input = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter an interger number!");
                input = Console.ReadLine();
                while (!int.TryParse(input, out num))
                {
                    Console.WriteLine("Invalid input. Please enter an interger number!");
                    input = Console.ReadLine();
                }
                stack.Push(num);
            }
            PrintStack(stack);
            Console.ReadKey();
        }

        public static void PrintStack(Stack<int> stack)
        {
            int n = stack.Count;
            for (int i = 0; i < n; i++)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}