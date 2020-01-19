using System;

namespace Exercise11
{
    internal class TestProgram
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Test!");
            //Create new LinkedList
            DoubleLinkedList<int> testLinkedList = new DoubleLinkedList<int>();
            //Add an element at beginning of the List
            testLinkedList.AddFirst(100);
            PrintResult(testLinkedList.ToArray());
            //Add an element at the end of the List
            testLinkedList.AddLast(200);
            PrintResult(testLinkedList.ToArray());
            testLinkedList.AddFirst(0);
            //Add an element after/before a given index
            testLinkedList.AddAfter(50, 0);
            testLinkedList.AddBefore(150, 3);
            PrintResult(testLinkedList.ToArray());
            testLinkedList.AddAfter(250, 4);
            testLinkedList.AddBefore(300, 6);
            PrintResult(testLinkedList.ToArray());
            ////Remove the first and last elements of the List
            testLinkedList.RemoveFirst();
            testLinkedList.RemoveLast();
            PrintResult(testLinkedList.ToArray());
            //Remove the first element with value equal 100
            testLinkedList.Remove(100);
            PrintResult(testLinkedList.ToArray());
            testLinkedList.AddLast(testLinkedList.Find(250).Value);
            PrintResult(testLinkedList.ToArray());
            //Get the element at a given index
            Console.WriteLine("Element at index 3 is: {0}", testLinkedList.GetElementAtIndex(3).Value);
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