using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTree
{
    class Tree<T>
    {
        private TreeNode<T> root;
        public Tree(T value)
        {
            if(value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            this.root = new TreeNode<T>(value);
        }
        public Tree(T value, params Tree<T>[] children):this(value)
        {
            foreach(Tree<T> child in children )
            {
                this.root.AddChild(child.root);
            }
        }
        public TreeNode<T> Root
        {
            get { return this.root; }
        }
        /// <summary>
        /// Traverses and prints the tree in Depth-First Search (DFS) manner
        /// </summary>
        /// <param name="root">the root of the tree to be traversed</param>
        /// <param name="space">the spaces used for representation of the parent-child relation</param>
        private void PrintDFS(TreeNode<T> root,string space)
        {
            if(this.root == null)
            {
                return;
            }
            Console.WriteLine(space + root.Value);
            TreeNode<T> child = null;
            for(int i =0; i< root.ChildrenCount;i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, space + " ");
            }
        }
        public void TraverserDFS()
        {
            this.PrintDFS(this.root, string.Empty);
        }
    }
}
