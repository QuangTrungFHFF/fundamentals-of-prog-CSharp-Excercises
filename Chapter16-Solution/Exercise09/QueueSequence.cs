using System;
using System.Collections.Generic;

namespace Exercise09
{
    /// <summary>
    /// We are given the following sequence:
    ///S1 = N;
    ///S2 = S1 + 1;
    ///S3 = 2* S1 + 1;
    ///S4 = S1 + 2;
    ///S5 = S2 + 1;
    ///S6 = 2* S2 + 1;
    ///S7 = S2 + 2;
    ///…
    ///Using the Queue<T> class, write a program which by given N prints on the console the first 50 elements of the sequence.
    /// </summary>
    internal class QueueSequence
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter N!");
            PrintSequence(2);
        }

        public static void PrintSequence(int n)
        {            
            var queue = new Queue<int>();
            
            for (int i = 0; i<17;i++)
            {
                //queue.Enqueue(n);
                
                queue.Enqueue(n + 1);
                queue.Enqueue(2 * n + 1);
                queue.Enqueue(n + 2);
                n = queue.Peek();
                Console.WriteLine(queue.Dequeue());
            }
            for(int j = 17; j<50;j++)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}