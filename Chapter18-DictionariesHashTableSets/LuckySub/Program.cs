using System;
using System.Collections.Generic;

namespace Exercise13
{
    /// <summary>    
    /// We are given a sequence P containing L integers L (1 < L < 50,000) and a number N. We call a “lucky sub-sequence within P” every sub-sequence of integers from P with a sum equal to N.
    /// Imagine we have a sequence S, holding all the lucky sub-sequences of P, kept in decreasing order by their length.When the length is the same, the sequences are ordered in decreasing 
    /// order by their elements: from the leftmost to the rightmost.Write a program to return the first 10 elements of S.
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new List<int>() { 1, 1, 2, 1, -1, 2, 3, -1, 1, 2, 3, 5, 1, -1, 2, 3 };
            LuckySub lucky = new LuckySub(sequence, 5);
            lucky.GetLuckySubsequences();
        }
        
    }
}
