using System;

namespace Exercise10
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            int max = 0;
            Console.WriteLine("Please enter max range!");
            string input = Console.ReadLine();
            while(!int.TryParse(input,out max)|| max<0)
            {
                Console.WriteLine("Please enter an interger > 0!");
                input = Console.ReadLine();
            }
            var sequence = new Sequences(max);
            sequence.PrintResult();
            
        }
    }
}
