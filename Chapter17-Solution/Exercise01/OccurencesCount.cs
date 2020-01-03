using SimpleTree;
using System;
using System.Collections.Generic;

namespace Exercise01
{
    internal class OccurencesCount
    {
        private static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(14,
                                     new Tree<int>(6,
                                        new Tree<int>(23),
                                        new Tree<int>(6,
                                            new Tree<int>(10),
                                            new Tree<int>(21))),
                                     new Tree<int>(15,
                                        new Tree<int>(3)));
            Console.WriteLine("There are {0} occurence(s) of number 6 in the tree.", CountOccurences(tree, 6));
        }

        /// <summary>
        /// Count number of occurences of given number in a tree using DFS.
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int CountOccurences(Tree<int> tree, int number)
        {
            int count = 0;
            Stack<TreeNode<int>> numberTree = new Stack<TreeNode<int>>();
            numberTree.Push(tree.Root);
            while (numberTree.Count > 0)
            {
                TreeNode<int> currentNode = numberTree.Pop();
                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {
                    if (currentNode.GetChild(i).Value == number)
                    {
                        count++;
                    }
                    numberTree.Push(currentNode.GetChild(i));
                }
            }
            return count;
        }
    }
}