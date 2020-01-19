using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10
{
    class Node
    {
        private Node previous;
        public int Value { get; set; }
        public Node(Node previous, int value)
        {
            this.previous = previous;
            this.Value = value;
        }
        public void Print()
        {
            if (previous!=null)
            {
                previous.Print();
            }
            Console.WriteLine("{0,4}", Value);
        }
    }
}
