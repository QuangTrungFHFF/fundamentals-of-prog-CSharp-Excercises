using MsdnDirectedGraph;
using System;
using System.Collections.Generic;

namespace Exercise14
{
    internal class ConnectedComponents
    {
        private static void Main(string[] args)
        {
            //Add nodes and some edges to the graph
            List<Node> nodes = new List<Node>();
            nodes.Add(new Node<int>(0));
            nodes.Add(new Node<int>(1));
            nodes.Add(new Node<int>(2));
            nodes.Add(new Node<int>(3));
            nodes.Add(new Node<int>(4));
            nodes.Add(new Node<int>(5));
            nodes.Add(new Node<int>(6));
            nodes.Add(new Node<int>(7));
            nodes.Add(new Node<int>(8));
            nodes.Add(new Node<int>(9));
            nodes.Add(new Node<int>(10));
            nodes.Add(new Node<int>(11));

            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(nodes[0], nodes[1], 1));
            edges.Add(new Edge(nodes[1], nodes[2], 1));
            edges.Add(new Edge(nodes[1], nodes[0], 1));
            edges.Add(new Edge(nodes[2], nodes[1], 1));
            edges.Add(new Edge(nodes[7], nodes[8], 1));

            Graph testGraph = new Graph(edges, nodes);

            //Add new edges to the graph (connecting nodes)
            testGraph.AddEdge(testGraph.Nodes[0], testGraph.Nodes[5], 1, true);
            testGraph.AddEdge(testGraph.Nodes[0], testGraph.Nodes[6], 1, true);
            testGraph.AddEdge(testGraph.Nodes[1], testGraph.Nodes[6], 1, true);
            testGraph.AddEdge(testGraph.Nodes[2], testGraph.Nodes[4], 1, true);
            testGraph.AddEdge(testGraph.Nodes[2], testGraph.Nodes[5], 1, true);
            testGraph.AddEdge(testGraph.Nodes[4], testGraph.Nodes[3], 1, true);
            testGraph.AddEdge(testGraph.Nodes[3], testGraph.Nodes[5], 1, true);
            testGraph.AddEdge(testGraph.Nodes[3], testGraph.Nodes[6], 1, true);
            testGraph.AddEdge(testGraph.Nodes[9], testGraph.Nodes[10], 1, true);
            testGraph.AddEdge(testGraph.Nodes[10], testGraph.Nodes[11], 1, true);

            Component comp = new Component(testGraph);
            Console.WriteLine("There are {0} component(s) in the graph.", comp.ComponentCount);
            Console.WriteLine("List of all components:");
            foreach (List<Node> subgraph in comp.AllComponents)
            {
                subgraph.ToConsole();
            }
        }
    }

    public static class EnumerableHelper
    {
        public static void ToConsole<T>(this IEnumerable<T> enumerable)
        {
            foreach (T item in enumerable)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("");
        }
    }
}