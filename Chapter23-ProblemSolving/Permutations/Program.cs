using System;

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
        }
    }
}
