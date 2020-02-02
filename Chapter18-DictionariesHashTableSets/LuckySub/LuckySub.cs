using System;
using System.Collections.Generic;

namespace Exercise13
{
    /// <summary>
    /// We are given a sequence P containing L integers L (1 < L < 50,000) and a number N. We call a “lucky sub-sequence within P” every sub-sequence of integers from P with a sum equal to N.
    /// Imagine we have a sequence S, holding all the lucky sub-sequences of P, kept in decreasing order by their length.When the length is the same, the sequences are ordered in decreasing
    /// order by their elements: from the leftmost to the rightmost.Write a program to return the first 10 elements of S.
    /// </summary>
    internal class LuckySub
    {
        private readonly int givenSum;
        private List<int> sequence;
        public int Count { get; private set; }
        public TreeMultySet<Sequence<int>> firstTenElements { get; private set; }

        public LuckySub(List<int> sequence, int givenSum)
        {
            this.givenSum = givenSum;
            this.sequence = sequence;
            this.firstTenElements = new TreeMultySet<Sequence<int>>();
            this.Count = 0;
        }

        public void GetLuckySubsequences()
        {
            for (int start = 0; start < this.sequence.Count; start++)
            {
                int currentSum = 0;
                List<int> subSequence = new List<int>();
                for (int currentEnd = start; currentEnd < this.sequence.Count; currentEnd++)
                {
                    subSequence.Add(sequence[currentEnd]);
                    currentSum += sequence[currentEnd];

                    if (currentSum == this.givenSum)
                    {
                        this.firstTenElements.Add(new Sequence<int>(subSequence));
                        this.Count++;
                        if (this.Count > 10)
                        {
                            this.firstTenElements.DeleteSingleMax();
                        }
                    }
                }
            }
            PrintLuckySub();
        }

        public void PrintLuckySub()
        {
            if (this.Count < 1)
            {
                Console.WriteLine("No Lucky Sub-Sequence found! :(");
            }
            else
            {
                Console.WriteLine("{0} Lucky Sub-Sequences found!", this.Count);
                Console.WriteLine("First 10 Lucky Sub-Sequences (Decreasing order by length)");
                foreach (var sub in this.firstTenElements)
                {
                    for (int i = 0; i < sub.Value; i++)
                    {
                        sub.Key.PrintSequence();
                    }
                }
            }
        }
    }
}