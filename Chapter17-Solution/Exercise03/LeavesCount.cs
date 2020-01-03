using SimpleTree;
using System;
using System.Collections.Generic;

namespace Exercise03
{
    /// <summary>
    /// Write a program that finds the number of leaves and number of internal vertices of a tree.
    /// </summary>
    internal class LeavesCount
    {
        private static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(14,
                                           new Tree<int>(9,
                                                        new Tree<int>(23),
                                                        new Tree<int>(6,
                                                                      new Tree<int>(10),
                                                                      new Tree<int>(21))),
                                           new Tree<int>(15,
                                                         new Tree<int>(3)));
            LeavesAndInternalVerticesCount(tree);
        }

        /// <summary>
        /// Count and print on the console number of leaves of the tree.
        /// Calculate and print on the console number of interal vertices of the tree (using total number of nodes minus number of leaves and root).
        /// </summary>
        /// <param name="tree"></param>
        public static void LeavesAndInternalVerticesCount(Tree<int> tree)
        {
            var nodeStack = new Stack<TreeNode<int>>();
            TreeNode<int> currentNode = tree.Root;
            nodeStack.Push(currentNode);
            int count = 0;
            while (nodeStack.Count > 0)
            {
                currentNode = nodeStack.Pop();
                if (currentNode.ChildrenCount == 0)
                {
                    count++;
                }
                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {
                    nodeStack.Push(currentNode.GetChild(i));
                }
            }
            Console.WriteLine("Number of leaves of the tree: {0}.", count);
            Console.WriteLine("Number of internal vertices of the tree: {0}", SubNodeCount(tree.Root) - count - 1);
        }

        /// <summary>
        /// Count number of nodes in a sub-tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int SubNodeCount(TreeNode<int> node)
        {
            var nodeStack = new Stack<TreeNode<int>>();
            TreeNode<int> currentNode = node;
            int count = 0;
            nodeStack.Push(currentNode);
            while (nodeStack.Count > 0)
            {
                currentNode = nodeStack.Pop();
                count++;
                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {
                    nodeStack.Push(currentNode.GetChild(i));
                }
            }
            return count;
        }
    }
}