using System;
using System.Collections.Generic;
using System.Text;

namespace MsdnUnDirectedGraph
{
    public class Graph
    {
        public List<Edge> Edges { get; set; }
        public List<Node> Nodes { get; set; }

        public Graph(List<Edge> edges, List<Node> nodes)
        {
            this.Edges = edges;
            this.Nodes = nodes;
            foreach (Node node in nodes)
            {
                node.Graph = this;
            }
        }
        public bool isEdgeExist(Node node, Node neighborNode)
        {
            foreach(Edge e in Edges)
            {
                if(e.Neighbor.Contains(node)&&e.Neighbor.Contains(neighborNode))
                {
                    return true;
                }
            }
            return false;
        }        

        public void AddEdge(Node from, Node to)
        {
            if(!isEdgeExist(from, to))
            {
                this.Edges.Add(new Edge(from, to));
            }
            
        }

        public void AddNode(Node node)
        {
            this.Nodes.Add(node);
            node.Graph = this;
        }

        public void RemoveEdge(Edge edge)
        {
            this.Edges.Remove(edge);
        }

        public void RemoveNode(Node node)
        {
            this.Edges.RemoveAll(e => e.Neighbor.Contains(node));
            this.Nodes.Remove(node);
        }
    }
}
