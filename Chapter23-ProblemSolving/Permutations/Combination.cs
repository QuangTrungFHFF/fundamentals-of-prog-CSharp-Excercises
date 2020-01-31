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

        public static List<List<T>> GetCombinationsWithRepetition<T>(List<T> list, int k)
        {     
            var combinations = new List<List<T>>();

            if(k == 0)
            {
                combinations.Add(new List<T>());
                return combinations;
            }

            if(list.Count ==0)
            {
                return combinations;
            }

            T head = list[0];
            var listClone = new List<T>(list);

            List<List<T>> subcombinations = GetCombinationsWithRepetition(listClone, k - 1);

            foreach(var sub in subcombinations)
            {
                sub.Insert(0,head);
                combinations.Add(sub);
            }

            list.RemoveAt(0);
            combinations.AddRange(GetCombinationsWithRepetition(list, k));
            return combinations;
        }


    }
}
