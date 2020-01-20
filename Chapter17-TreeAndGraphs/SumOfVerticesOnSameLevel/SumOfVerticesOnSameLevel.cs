using System;
using BinaryTree;
using System.Collections.Generic;
namespace Exercise04
{
    /// <summary>
    /// Write a program that finds in a binary tree of numbers the sum of the vertices of each level of the tree.
    /// </summary>
    class SumOfVerticesOnSameLevel
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>(14,
                                           new BinaryTree<int>(9,
                                                        new BinaryTree<int>(23),
                                                        new BinaryTree<int>(6,
                                                                      new BinaryTree<int>(10),
                                                                      new BinaryTree<int>(21))),
                                           new BinaryTree<int>(15,
                                                         new BinaryTree<int>(3),null));
            PrintSumOfAllLevel(tree);
        }
        /// <summary>
        /// Get the depth of the binary tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int getDepth(BinaryTree<int> root)
        {
            if(root.LeftChild==null&&root.RightChild==null)
            {
                return 0;
            }
            int leftCount = 0;
            if(root.LeftChild!=null)
            {
                leftCount = getDepth(root.LeftChild);
            }
            int rightCount = 0;
            if(root.RightChild!= null)
            {
                rightCount = getDepth(root.RightChild);
            }
            return (Math.Max(leftCount, rightCount) + 1);
        }

        // Recursive function to update sum[] array  
        // such that sum[i] stores the sum  
        // of all the elements at ith level 
        public static void GetSumOfVertices(BinaryTree<int> currentNode, int level, int[] sum)
        {
            if(currentNode == null)
            {
                return;
            }
            sum[level] += currentNode.Value;
            GetSumOfVertices(currentNode.LeftChild, level + 1, sum);
            GetSumOfVertices(currentNode.RightChild, level + 1, sum);
        }
        /// <summary>
        /// Print to console all the Sum at each level
        /// </summary>
        /// <param name="root"></param>
        public static void PrintSumOfAllLevel(BinaryTree<int> root)
        {
            var sum = new int[getDepth(root)+1];
            GetSumOfVertices(root, 0, sum);
            for(int i=0;i<sum.Length;i++)
            {
                Console.WriteLine("Level: {0} - Sum: {1}", i, sum[i]);
            }
        }
    }
}
