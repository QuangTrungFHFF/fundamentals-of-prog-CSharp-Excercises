using System;

namespace Exercise12
{
    /// <summary>
    /// Create a DynamicStack<T> class to implement dynamically a stack (like a linked list, where each element knows its previous element and the stack knows its last element).
    /// Add methods for all commonly used operations like Push(), Pop(), Peek(), Clear() and Count.
    /// </summary>
    class TestProgram
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Test!");
            DynamicStack<int> testStack = new DynamicStack<int>();
            testStack.Push(100);            
            testStack.Push(200);            
            testStack.Push(300);
            testStack.Push(400);
            testStack.Push(500);            
            PrintResult(testStack.ToArray());
            Console.WriteLine("There are {0} elements in Stack.",testStack.Count);
            testStack.Pop();
            Console.WriteLine(testStack.Pop().Value);            
            PrintResult(testStack.ToArray());
            Console.WriteLine("Element on top of Stack is: {0} ", testStack.Peek().Value);
            testStack.Clear();
            PrintResult(testStack.ToArray());

        }
        public static void PrintResult(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n-----------------------------------");
        }
    }
}
