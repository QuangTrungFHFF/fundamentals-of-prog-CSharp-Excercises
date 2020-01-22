using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceExtension
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = new int[] { 2, 5, 63, 21, 4, 58, 96, 74, 10 };
            numbers.ToConsole();
            Console.WriteLine($"Sum of all elements: {numbers.Sum():N0}");
            Console.WriteLine($"Average: {numbers.Average():N2}");
            Console.WriteLine($"Max: {numbers.Max()}");
            Console.WriteLine($"Min: {numbers.Min()}");
        }
    }

    public static class IEnumerableExtension
    {
        public static void ToConsole<T>(this IEnumerable<T> elements)
        {
            foreach(var e in elements)
            {
                Console.Write(e.ToString() + " ");
            }
            Console.WriteLine("");
        }
        public static double Sum<T>(this IEnumerable<T> elements)
            where T : IComparable<T>
        {
            double result = 0;
            try
            {
                foreach (var e in elements)
                {
                    result += Convert.ToDouble(e);
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Element cannot be sum!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Cannot convert string element to default format due to incorrect format!");
            }
            return result;
        }

        public static double Average<T>(this IEnumerable<T> elements)
            where T : IComparable<T>
        {
            int count = 0;
            foreach (var e in elements)
            {
                count++;
            }
            double sum = Sum<T>(elements);
            double result = sum / (double)count;
            return result;
        }

        public static T Min<T>(this IEnumerable<T> elements)
            where T : IComparable<T>
        {
            T min = elements.First();
            foreach (var e in elements)
            {
                if (e.CompareTo(min) < 0)
                {
                    min = e;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> elements)
            where T : IComparable<T>
        {
            T max = elements.First();
            foreach (var e in elements)
            {
                if (e.CompareTo(max) > 0)
                {
                    max = e;
                }
            }
            return max;
        }
    }
}