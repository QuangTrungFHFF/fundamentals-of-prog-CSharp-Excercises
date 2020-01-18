using System;
using System.Globalization;
using System.Text;

namespace Exercise12
{
    /// <summary>
    /// /// Write a program that reads a number from console and prints it in 15-character field,
    /// aligned right in several ways: as a decimal number, hexadecimal number, percentage, currency and exponential (scientific) notation.
    /// </summary>
    class NumberFormating
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Please enter a number!");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("{0,15:D}",(int)number); //Print decimal number
            Console.WriteLine("{0,15:X4}", (int)number); // Print hexadecimal number ("x" or "X")
            Console.WriteLine("{0,15}", number.ToString("P1", CultureInfo.CreateSpecificCulture("de-DE"))); //Percentage
            Console.WriteLine("{0,15}", number.ToString("C2",CultureInfo.CreateSpecificCulture("fr-FR")));
        }
    }
}
