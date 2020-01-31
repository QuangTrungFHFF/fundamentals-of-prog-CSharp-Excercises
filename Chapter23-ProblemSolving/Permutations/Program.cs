using System;
using System.Collections.Generic;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            PermutationUsingHeap permutation = new PermutationUsingHeap();
            int[] values = new int[] { 0, 1, 2, 4 };
            PermutationUsingHeap.ForAllPermutation(values, (vals) =>
            {
                Console.WriteLine(String.Join("", vals));
                return false;
            });

            Console.WriteLine("--------------------------------");

            Combination combination = new Combination();
            var result = Combination.GetCombinationsWithoutRepetition(3, 4);

            foreach(var r in result)
            {
                Console.WriteLine(r.);
            }
            
        }
    }

    public static class IENumberableHedlper<T>
    {
        public static void ToConsole(this IEnumerable<T> ts)
        {

        }
    }
}
