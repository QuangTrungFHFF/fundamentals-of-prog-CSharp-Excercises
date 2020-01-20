using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MsdnUnDirectedGraph
{
    public abstract class Node
    {
        public Graph Graph { get; internal set; }
        public bool Visited { get; set; }
        public List<Edge> Edges
        {
            get
            {
                return Graph.Edges.Where(e => e.Neighbor.Contains(this)).ToList();
            }
        }
    }
    public class Node<T> : Node
    {
        public T Value { get; private set; }
        public Node(T value)
        {
            this.Value = value;
            this.Visited = false;
        }
        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
