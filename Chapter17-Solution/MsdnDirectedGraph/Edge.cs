using System;
using System.Collections.Generic;
using System.Text;

namespace MsdnDirectedGraph
{
    public class Edge
    {
        public Node From { get; private set; }
        public Node To { get; private set; }
        public int Distance { get; private set; }
        public Edge(Node from,Node to,int distance)
        {
            this.From = from;
            this.To = to;
            this.Distance = distance;
        }
        public override string ToString()
        {
            return string.Format("{0} -> {1} - d: {2}", this.From, this.To,this.Distance);
        }
    }
}
