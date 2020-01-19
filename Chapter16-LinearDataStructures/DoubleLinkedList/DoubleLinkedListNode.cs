using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise11
{
    class DoubleLinkedListNode<T>
    {
        public T Value { get; private set; }
        public DoubleLinkedListNode<T> Previous { get; internal set; }
        public DoubleLinkedListNode<T> Next { get; internal set; }
        public DoubleLinkedListNode(T value)
        {
            Value = value;
        }
    }
}
