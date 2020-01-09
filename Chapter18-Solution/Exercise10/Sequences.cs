using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10
{
    class Sequences
    {
        private HashSet<int> sequenceF1;
        private HashSet<int> sequenceF2;
        private HashSet<int> sequenceF3;
        public Sequences(int max)
        {
            this.GetF1(max);
            this.GetF2(max);
            this.GetF3(max);
        }
        public void PrintResult()
        {
            var result = new HashSet<int>(sequenceF1);
            Console.WriteLine("Intersect");
            Console.WriteLine("f1*f2: ");
            result.IntersectWith(sequenceF2);
            PrintHashSet(result);
            Console.WriteLine("f1*f3: ");
            result = new HashSet<int>(sequenceF1);
            result.IntersectWith(sequenceF3);
            PrintHashSet(result);
            Console.WriteLine("f2*f3: ");
            result = new HashSet<int>(sequenceF2);
            result.IntersectWith(sequenceF3);
            PrintHashSet(result);
            Console.WriteLine("f1*f2*f3: ");
            result = new HashSet<int>(sequenceF1);
            result.IntersectWith(sequenceF2);
            result.IntersectWith(sequenceF3);
            PrintHashSet(result);

            Console.WriteLine("Union");
            Console.WriteLine("f1+f2: ");
            result = new HashSet<int>(sequenceF1);
            result.UnionWith(sequenceF2);
            PrintHashSet(result);
            Console.WriteLine("f1+f3: ");
            result = new HashSet<int>(sequenceF1);
            result.UnionWith(sequenceF3);
            PrintHashSet(result);
            Console.WriteLine("f2+f3: ");
            result = new HashSet<int>(sequenceF2);
            result.UnionWith(sequenceF3);
            PrintHashSet(result);
            Console.WriteLine("f1+f2+f3: ");
            result = new HashSet<int>(sequenceF1);
            result.UnionWith(sequenceF2);
            result.UnionWith(sequenceF3);
            PrintHashSet(result);
        }
        private static void PrintHashSet(HashSet<int> hashSet)
        {
            foreach(int i in hashSet)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
        private void GetF1(int max)
        {
            var sequence = new List<int>() { 1 };
            int n = 2* sequence[0] +3;
            sequence.Add(n);
            int k = 1;
            while (n<max)
            {
                n = 2 * sequence[k] + 3;
                sequence.Add(n);
                k++;
            }
            foreach(int i in sequence)
            {
                sequenceF1.Add(i);
            }
        }
        private void GetF2(int max)
        {
            var sequence = new List<int>() { 2 };
            int n = 3 * sequence[0] + 1;
            sequence.Add(n);
            int k = 1;
            while (n < max)
            {
                n = 3 * sequence[k] + 1;
                sequence.Add(n);
                k++;
            }
            foreach (int i in sequence)
            {
                sequenceF2.Add(i);
            }
        }
        private void GetF3(int max)
        {
            var sequence = new List<int>() { 2 };
            int n = 2 * sequence[0] - 1;
            sequence.Add(n);
            int k = 1;
            while (n < max)
            {
                n = 2 * sequence[k] -1;
                sequence.Add(n);
                k++;
            }
            foreach (int i in sequence)
            {
                sequenceF3.Add(i);
            }
        }
    }
}
