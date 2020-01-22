using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceExtension
{
    internal class Program
    {
        private static void Main(string[] args)
        {

        }
    }

    public static class IEnumerableExtension
    {
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