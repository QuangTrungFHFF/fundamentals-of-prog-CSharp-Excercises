using System;
using System.Collections.Generic;

namespace MsdnUnDirectedGraph
{
    public class Edge
    {
        public List<Node> Neighbor { get; private set; }
               
        public Edge(Node from, Node to)
        {
            Neighbor = new List<Node>();
            Neighbor.Add(from);
            Neighbor.Add(to);
        }
        public override string ToString()
        {
            return string.Format("{0} <-> {1}", this.Neighbor[0], this.Neighbor[1]);
        }
    }
}
