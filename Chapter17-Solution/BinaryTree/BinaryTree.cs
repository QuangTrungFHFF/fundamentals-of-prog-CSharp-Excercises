using System;

namespace BinaryTree
{
    public class BinaryTree<T>
    {
        public T Value { get; set; }
        public BinaryTree<T> LeftChild { get; private set; }
        public BinaryTree<T> RightChild { get; private set; }
        public BinaryTree(T value, BinaryTree<T> leftChild, BinaryTree<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }
        public BinaryTree(T value) : this(value,null,null)
        {
        }
        public void PrintInOrder()
        {
            if (this.LeftChild!= null)
            {
                this.LeftChild.PrintInOrder();
            }
            Console.WriteLine(this.Value+" ");
            if(this.RightChild!= null)
            {
                this.RightChild.PrintInOrder();
            }
        }
        public void PrintPreOrder()
        {
            Console.WriteLine(this.Value+" ");
            if (this.LeftChild != null)
            {
                this.LeftChild.PrintPreOrder();
            }            
            if (this.RightChild != null)
            {
                this.RightChild.PrintPreOrder();
            }
        }
        public void PrintPostOrder()
        {
            
            if (this.LeftChild != null)
            {
                this.LeftChild.PrintPostOrder();
            }            
            if (this.RightChild != null)
            {
                this.RightChild.PrintPostOrder();
            }
            Console.WriteLine(this.Value + " ");
        }
    }
}
