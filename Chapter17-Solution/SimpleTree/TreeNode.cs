using System;
using System.Collections.Generic;

namespace SimpleTree
{
    public class TreeNode<T>
    {
        
        private bool hasParent;
        private List<TreeNode<T>> children;
        
        public TreeNode(T value)
        {
            if(value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            Value = value;
            this.children = new List<TreeNode<T>>();
        }
        public T Value { get; set; }
        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }
        public override string ToString()
        {
            return this.Value.ToString();
        }
        /// <summary>
        /// Add new child to the parent node
        /// </summary>
        /// <param name="child"></param>
        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            if (child.hasParent)
            {
                throw new ArgumentException("This node already has a parent!");
            }
            child.hasParent = true;
            this.children.Add(child);
        }
        /// <summary>
        /// Gets the child of the node at given index
        /// </summary>
        /// <param name="index">the index of the desired child</param>
        /// <returns>the child on the given position</returns>
        public TreeNode<T> GetChild(int index)
        {
            if(index>(this.ChildrenCount-1))
            {
                throw new ArgumentException("This node has no children at that index!");
            }
            return this.children[index];
        }
    }
}
