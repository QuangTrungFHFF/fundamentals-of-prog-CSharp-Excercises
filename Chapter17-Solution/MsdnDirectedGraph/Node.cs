using System;
using System.Collections.Generic;
using System.Linq;
namespace MsdnDirectedGraph
{
    public abstract class Node
    {
        public Graph Graph { get; internal set; }
        public List<Edge> InboundEdges
        {
            get
            {
                return Graph.Edges.Where(e => e.To == this).ToList();
            }
        }
        public List<Edge> OutboundEdges
        {
            get
            {
                return Graph.Edges.Where(e => e.From == this).ToList();
            }
        }

    }
    public class Node<T> :Node
    {
        public T Value { get; private set; }
        public Node(T value)
        {
            this.Value = value;
        }
        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
