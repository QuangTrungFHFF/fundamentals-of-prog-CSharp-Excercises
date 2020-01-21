using System;

namespace RefactorCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int value = 10;
            int i = 0;
            switch (value)
            {
                case 10:
                    int w = 5;
                    Console.WriteLine(w);
                    break;

                case 9:
                    i = 0;
                    break;

                case 8:
                    Console.WriteLine(8);
                    break;

                default:
                    Console.WriteLine("def");
                    {
                        Console.WriteLine("hoho");
                    }
                    for (int k = 0; k < i; k++)
                    {
                        Console.WriteLine(k - 'f');
                    }
                    break;
            }
            Console.WriteLine("loop!");
        }
    }
}