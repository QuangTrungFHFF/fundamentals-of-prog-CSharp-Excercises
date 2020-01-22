using System;
using System.Collections.Generic;

namespace InterfaceExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public static class IEnumerableExtension
    {
        public static double Sum<T>(this IEnumerable<T> elements)
            where T:IComparable<T>
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
            catch(FormatException)
            {
                Console.WriteLine("Cannot convert string element to default format due to incorrect format!");
            }
            return result;    
        }
    }
}
