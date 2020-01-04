using System;
using System.Collections.Generic;
using System.Text;

namespace MsdnDirectedGraph
{
    public class Edge
    {
        public Node From { get; private set; }
        public Node To { get; private set; }
        public Edge(Node from,Node to)
        {
            this.From = from;
            this.To = to;
        }
        public override string ToString()
        {
            return string.Format("{0} -> {1}", this.From, this.To);
        }
    }
}
