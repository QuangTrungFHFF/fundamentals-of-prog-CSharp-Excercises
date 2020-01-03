using System;
using SimpleTree;
using System.Collections.Generic;

namespace Exercise02
{
    /// <summary>
    /// Write a program that displays the roots of those sub-trees of a tree, which have exactly k nodes, where k is an integer.
    /// </summary>
    class RootWithGivenNumberOfSubs
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(14,
                                           new Tree<int>(9,
                                                        new Tree<int>(23),
                                                        new Tree<int>(6,
                                                                      new Tree<int>(10),
                                                                      new Tree<int>(21))),
                                           new Tree<int>(15,
                                                         new Tree<int>(3)));
            Console.WriteLine("Total node in the tree: {0}",SubNodeCount(tree.Root));
            Console.WriteLine("Sub-tree that has 5 nodes is: ");
            GetSubTrees(tree, 5);
        }
        /// <summary>
        /// Print the sub-tree with k number of nodes (including root) to the console
        /// </summary>
        /// <param name="k">number of nodes in each subtree</param>
        public static void GetSubTrees(Tree<int> tree,int k)
        {
            var nodeQueue = new Queue<TreeNode<int>>();
            TreeNode<int> currentNode = tree.Root;
            nodeQueue.Enqueue(currentNode);
            while(nodeQueue.Count>0)
            {
                currentNode = nodeQueue.Dequeue();
                if(SubNodeCount(currentNode)==k)
                {
                    Console.WriteLine(currentNode.ToString());
                }
                else if(SubNodeCount(currentNode)>k)
                {
                    for(int i =0; i< currentNode.ChildrenCount;i++)
                    {
                        nodeQueue.Enqueue(currentNode.GetChild(i));
                    }
                    
                }
            }
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
            while(nodeStack.Count>0)
            {
                currentNode = nodeStack.Pop();
                count++;
                for(int i =0;i<currentNode.ChildrenCount;i++)
                {
                    nodeStack.Push(currentNode.GetChild(i));
                }
            }
            return count;
        }
    }
}
