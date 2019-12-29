using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise13
{
    class DequeLinkedListNode<T>
    {
        public T Value { get; private set; }
        public DequeLinkedListNode<T> Previous { get; internal set; }
        public DequeLinkedListNode<T> Next { get; internal set; }
        public DequeLinkedListNode(T value)
        {
            Value = value;
        }
    }
}
