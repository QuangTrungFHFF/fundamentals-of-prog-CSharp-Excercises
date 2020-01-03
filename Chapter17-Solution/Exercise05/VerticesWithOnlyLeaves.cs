using System;
using BinaryTree;
using System.Collections.Generic;
namespace Exercise05
{
    /// <summary>
    /// Write a program that finds and prints all vertices of a binary tree, which have for only leaves successors.
    /// </summary>
    class VerticesWithOnlyLeaves
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
                                                         new BinaryTree<int>(3), null));
            PrintVerticesWithOnlyLeaves(tree);
        }
        public static void PrintVerticesWithOnlyLeaves(BinaryTree<int> root)
        {
            var nodeQueue = new Queue<BinaryTree<int>>();
            BinaryTree<int> currentNode = root;
            nodeQueue.Enqueue(currentNode);
            while(nodeQueue.Count>0)
            {
                currentNode = nodeQueue.Dequeue();
                if(HasLeavesSuccessorsOnly(currentNode))
                {
                    Console.WriteLine("Vertice with Leave successors only: {0}", currentNode.Value.ToString());
                }
                if(currentNode.LeftChild!=null)
                {
                    nodeQueue.Enqueue(currentNode.LeftChild);
                }
                if(currentNode.RightChild!=null)
                {
                    nodeQueue.Enqueue(currentNode.RightChild);
                }
            }
        }
        /// <summary>
        /// Check if vertice has only leaves as successors
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static bool HasLeavesSuccessorsOnly(BinaryTree<int> node)
        {
            if(IsLeave(node))
            {
                return false;
            }
            if(IsLeave(node.LeftChild)&&IsLeave(node.RightChild))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Check if a node is a leave
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static bool IsLeave(BinaryTree<int> node)
        {
            if (node == null)
            {
                return true;
            }
            if (node.RightChild == null && node.LeftChild == null)
            {
                return true;
            }
            return false;
        }
    }
}
