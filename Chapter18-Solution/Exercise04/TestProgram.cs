using System;

namespace Exercise04
{
    /// <summary>
    /// Implement a DictHashSet<T> class, based on HashDictionary<K, V> class, we discussed in the text above.
    /// </summary>
    internal class TestProgram
    {
        private static void Main(string[] args)
        {
            //Create a DictHashSet<T>
            DictHashSet<int> numbers = new DictHashSet<int>();
            //Add items to DictHashSet
            Console.WriteLine("Add new items");
            Console.WriteLine(numbers.Add(0));
            Console.WriteLine(numbers.Add(1));
            Console.WriteLine(numbers.Add(2));
            Console.WriteLine(numbers.Add(100));
            Console.WriteLine(numbers.Add(200));
            Console.WriteLine(numbers.Add(300));
            Console.WriteLine(numbers.Add(400));
            Console.WriteLine(numbers.Add(500));
            Console.WriteLine(numbers.Add(600));
            //Add an already exist item
            Console.WriteLine("Add an already exist items");
            Console.WriteLine(numbers.Add(2));
            Console.WriteLine(numbers.Add(200));
            //Remove items
            Console.WriteLine("Remove items");
            Console.WriteLine(numbers.Remove(2));
            Console.WriteLine(numbers.Remove(99));
            //Check if the set contains certain items
            Console.WriteLine("Check if the set contains certain items");
            Console.WriteLine(numbers.Remove(0));
            Console.WriteLine(numbers.Remove(1));
            Console.WriteLine(numbers.Remove(3));
            //Copy the DictHashSet to an array
            Console.WriteLine("Copy the DictHashSet to an array");
            var numberArray = numbers.CopyTo();
            foreach (var i in numberArray)
            {
                Console.Write(i + " ");
            }
            //Clear the set
            Console.WriteLine("\nClear the set.");
            numbers.Clear();
            //Test Union Function
            Console.WriteLine("Test Union Function");
            var newSet = new DictHashSet<int>();
            foreach (int i in numberArray)
            {
                newSet.Add(i);
            }
            numbers.UnionWith(newSet);
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            //Test Intersect Function
            Console.WriteLine("\nTest Intersect Function.");
            newSet.Remove(100);
            newSet.Add(2000);
            numbers.IntersectWith(newSet);
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            //Test Except Function
            Console.WriteLine("\nTest Except Function.");
            numbers.Add(3000);
            numbers.Add(4000);
            numbers.ExceptWith(newSet);
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}