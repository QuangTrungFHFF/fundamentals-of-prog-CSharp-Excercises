using System;
using System.Collections.Generic;
using System.Text;

namespace Permutations
{
    public class PermutationUsingHeap
    {
        public static bool ForAllPermutation<T>(T[] items, Func<T[],bool> funcExecuteAndTellIfShouldStop)
        {
            int countOfItems = items.Length;

            if(countOfItems <=1)
            {
                return funcExecuteAndTellIfShouldStop(items);
            }

            var index = new int[countOfItems];
            for(int i =0; i<countOfItems;i++)
            {
                index[i] = 0;
            }

            if(funcExecuteAndTellIfShouldStop(items))
            {
                return true;
            }

            for(int i =1;i<countOfItems;)
            {
                if(index[i]<i)
                {
                    if(i%2 ==1)
                    {
                        Swap(ref items[i], ref items[index[i]]);
                    }
                    else
                    {
                        Swap(ref items[i], ref items[0]);
                    }

                    if(funcExecuteAndTellIfShouldStop(items))
                    {
                        return true;
                    }

                    index[i]++;
                    i = 1;
                }
                else
                {
                    index[i++] = 0;
                }
            }
            return false;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
