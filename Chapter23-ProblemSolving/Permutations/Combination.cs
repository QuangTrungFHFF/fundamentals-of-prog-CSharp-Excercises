using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Permutations
{
    class Combination
    {
        public static IEnumerable<IEnumerable<T>> GetCombinationsWithoutRepetition<T>(IEnumerable<T> enumerable, int k)
        {
            List<T> list = enumerable.ToList();
            int n = list.Count();            
            T[] result = new T[k];
            var stack = new Stack<int>();
            stack.Push(0);
            
            while(stack.Count>0)
            {
                int index = stack.Count - 1;
                int current = stack.Pop();

                while (current < n)
                {
                    result[index++] = list[current++];                    
                    stack.Push(current);
                    if(index == k)
                    {
                        yield return (T[])result.Clone();
                        break;
                    }
                }
            }
        }



    }
}
