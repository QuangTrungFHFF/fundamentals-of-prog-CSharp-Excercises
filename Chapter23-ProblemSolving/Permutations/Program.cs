using System;
using System.Collections.Generic;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            PermutationUsingHeap permutation = new PermutationUsingHeap();
            int[] values = new int[] { 0 ,1, 2, 3 };
            PermutationUsingHeap.ForAllPermutation(values, (vals) =>
            {
                Console.WriteLine(String.Join("", vals));
                return false;
            });

            Console.WriteLine("--------------------------------");

            int[] values2 = new int[] { 0, 1, 2, 3 };
            Combination combination = new Combination();
            values2.ToConsole();
            var result = Combination.GetCombinationsWithoutRepetition(values2, 3);
            List<List<int>> save = new List<List<int>>();
            
            foreach(var r in result)
            {
                r.ToConsole();
            }

            Console.WriteLine("--------------------------------");

            var list = new List<int>() { 0, 1, 2, 3 };
            var combinationWithRepetition = Combination.GetCombinationsWithRepetition(list, 3);

            foreach (var r in combinationWithRepetition)
            {
                r.ToConsole();
            }
        }
    }

    public static class EnumberableHedlper
    {
        public static void ToConsole<T>(this IEnumerable<T> enumerable)
        {
            foreach(T item in enumerable)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
        }        
    }
}
