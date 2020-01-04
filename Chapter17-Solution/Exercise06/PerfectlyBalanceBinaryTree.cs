using BinaryTree;
using System;
using System.Collections.Generic;

namespace Exercise06
{
    internal class PerfectlyBalanceBinaryTree
    {
        private static void Main(string[] args)
        {
            BinaryTree<int> treeBalance = new BinaryTree<int>(14,
                                           new BinaryTree<int>(9,
                                                        new BinaryTree<int>(23),
                                                        new BinaryTree<int>(6)),
                                           new BinaryTree<int>(15,
                                                         new BinaryTree<int>(3),
                                                         new BinaryTree<int>(2)));
            BinaryTree<int> treeUnbalance = new BinaryTree<int>(14,
                                           new BinaryTree<int>(9,
                                                        new BinaryTree<int>(23),
                                                        new BinaryTree<int>(6,
                                                                      new BinaryTree<int>(10),
                                                                      new BinaryTree<int>(21))),
                                           new BinaryTree<int>(15,
                                                         new BinaryTree<int>(3), null));
            Console.WriteLine("Is first tree balance? - " + IsTreePerfectlyBalance(treeBalance));
            Console.WriteLine("Is second tree balance? - " + IsTreePerfectlyBalance(treeUnbalance));
        }

        /// <summary>
        /// Check if the entire tree is perfectly balance
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsTreePerfectlyBalance(BinaryTree<int> root)
        {
            bool isPerfect = true;
            var nodeQueue = new Queue<BinaryTree<int>>();
            BinaryTree<int> currentNode = root;
            nodeQueue.Enqueue(currentNode);
            while (nodeQueue.Count > 0)
            {
                currentNode = nodeQueue.Dequeue();
                if (!IsNodePerfectlyBalance(currentNode))
                {
                    isPerfect = false;
                }
                if (currentNode.LeftChild != null)
                {
                    nodeQueue.Enqueue(currentNode.LeftChild);
                }
                if (currentNode.RightChild != null)
                {
                    nodeQueue.Enqueue(currentNode.RightChild);
                }
            }
            return isPerfect;
        }

        /// <summary>
        /// Check if a node is perfectly balance
        /// Perfectly balanced binary tree – binary tree in which the difference in the left and right tree nodes’ count of any node is at most one.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsNodePerfectlyBalance(BinaryTree<int> node)
        {
            int leftCount = 0;
            int rightCount = 0;
            if (node.LeftChild != null)
            {
                leftCount = NodesCount(node.LeftChild);
            }
            if (node.RightChild != null)
            {
                rightCount = NodesCount(node.RightChild);
            }
            if (Math.Abs(leftCount - rightCount) <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Count subnodes of a node.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int NodesCount(BinaryTree<int> root)
        {
            var nodeStack = new Stack<BinaryTree<int>>();
            BinaryTree<int> currentNode = root;
            int count = 0;
            nodeStack.Push(currentNode);
            while (nodeStack.Count > 0)
            {
                currentNode = nodeStack.Pop();
                count++;
                if (currentNode.LeftChild != null)
                {
                    nodeStack.Push(currentNode.LeftChild);
                }
                if (currentNode.RightChild != null)
                {
                    nodeStack.Push(currentNode.RightChild);
                }
            }
            return count;
        }
    }
}