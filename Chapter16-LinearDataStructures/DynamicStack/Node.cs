using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise12
{
    class Node<T> 
    {
        public T Value { get;set; }
        public Node<T> Next { get; internal set; }
        public Node(T value)
        {
            Value = value;
        }
    }
}
