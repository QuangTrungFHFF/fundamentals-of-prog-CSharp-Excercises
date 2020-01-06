using System;
using System.Collections.Generic;
using MsdnUnDirectedGraph;

namespace Exercise17
{
    class TestProgram
    {
        static void Main(string[] args)
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

            //Add new edges to the graph (connecting nodes) 
            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(nodes[0], nodes[1]));            
            edges.Add(new Edge(nodes[2], nodes[1]));
            edges.Add(new Edge(nodes[7], nodes[8]));

            Graph testGraph = new Graph(edges, nodes);

            //Print information of the graph
            Console.WriteLine("Inital graph:");
            Console.WriteLine("Nodes:");
            testGraph.Nodes.ToConsole();
            Console.WriteLine("Edges:");
            testGraph.Edges.ToConsole();
            foreach(Node n in testGraph.Nodes)
            {
                Console.WriteLine("Edges of node {0}: ", n.ToString());
                n.Edges.ToConsole();
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
