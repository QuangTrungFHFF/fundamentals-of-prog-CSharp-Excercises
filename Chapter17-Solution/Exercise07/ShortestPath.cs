using MsdnDirectedGraph;
using System;
using System.Collections.Generic;

namespace Exercise07
{
    /// <summary>
    /// Let’s have as given a graph G(V, E) and two of its vertices x and y. Write a program that finds the shortest path between two vertices measured in number of vertices staying on the path.
    /// </summary>
    internal class ShortestPath
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

            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(nodes[0], nodes[1]));
            edges.Add(new Edge(nodes[1], nodes[2]));
            edges.Add(new Edge(nodes[1], nodes[0]));
            edges.Add(new Edge(nodes[2], nodes[1]));
            edges.Add(new Edge(nodes[7], nodes[8]));

            Graph testGraph = new Graph(edges, nodes);         

            //Add new edges to the graph (connecting nodes)
            testGraph.AddEdge(testGraph.Nodes[0], testGraph.Nodes[5], true);
            testGraph.AddEdge(testGraph.Nodes[0], testGraph.Nodes[6], true);
            testGraph.AddEdge(testGraph.Nodes[1], testGraph.Nodes[6], true);
            testGraph.AddEdge(testGraph.Nodes[2], testGraph.Nodes[4], true);
            testGraph.AddEdge(testGraph.Nodes[2], testGraph.Nodes[5], true);
            testGraph.AddEdge(testGraph.Nodes[4], testGraph.Nodes[3], true);
            testGraph.AddEdge(testGraph.Nodes[3], testGraph.Nodes[5], true);
            testGraph.AddEdge(testGraph.Nodes[3], testGraph.Nodes[6], true);

            //Print information of the graph
            Console.WriteLine("Inital graph:");
            Console.WriteLine("Nodes:");
            testGraph.Nodes.ToConsole();
            Console.WriteLine("Edges:");
            testGraph.Edges.ToConsole();
            Console.WriteLine("Inbound edges of {0}:", testGraph.Nodes[1]);
            testGraph.Nodes[1].InboundEdges.ToConsole();
            Console.WriteLine("Outbound edges of {0}:", testGraph.Nodes[1]);
            testGraph.Nodes[1].OutboundEdges.ToConsole();
        }
        public static void GetShortestPath(Node nodeX, Node nodeY)
        {
            if(nodeX.Graph!= nodeY.Graph)
            {
                Console.WriteLine("2 nodes are not in the same graph!");
                return;
            }

        }
    }
    public static class EnumerableHelper
    {
        public static void ToConsole<T>(this IEnumerable<T> enumerable)
        {
            foreach (T item in enumerable)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("");
        }
    }
}