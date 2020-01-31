﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Permutations
{
    class Combination
    {
        public static IEnumerable<int[]> GetCombinationsWithoutRepetition(int k, int n)
        {
            int[] result = new int[k];
            var stack = new Stack<int>(k);
            stack.Push(0);

            while(stack.Count>0)
            {
                int index = stack.Count - 1;
                int value = stack.Pop();

                while (value<n)
                {
                    result[index++] = value++;
                    stack.Push(value);

                    if(index == k)
                    {
                        yield return result;
                        break;
                    }
                }
            }
        }

    }
}