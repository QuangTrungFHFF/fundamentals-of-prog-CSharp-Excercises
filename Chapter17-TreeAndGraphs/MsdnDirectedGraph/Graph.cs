﻿using System.Collections.Generic;

namespace MsdnDirectedGraph
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

        public void AddEdge(Edge edge)
        {
            this.Edges.Add(edge);
        }

        public void AddEdge(Node from, Node to,int distance)
        {
            this.Edges.Add(new Edge(from, to, distance));
        }

        public void AddEdge(Node from, Node to,int distance, bool isTwoWay)
        {
            if (isTwoWay == true)
            {
                this.Edges.Add(new Edge(from, to, distance));
                this.Edges.Add(new Edge(to, from, distance));
            }
            else
            {
                this.Edges.Add(new Edge(from, to, distance));
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
            this.Edges.RemoveAll(e => e.From == node || e.To == node);
            this.Nodes.Remove(node);
        }
    }
}