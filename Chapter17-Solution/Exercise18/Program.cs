using System;
using MsdnUnDirectedGraph;
using System.Collections.Generic;

namespace Exercise18
{
    class Program
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

            //Add new edges to the graph (connecting nodes)
            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(nodes[0], nodes[1]));
            edges.Add(new Edge(nodes[0], nodes[3]));
            edges.Add(new Edge(nodes[1], nodes[2]));
            edges.Add(new Edge(nodes[1], nodes[3]));
            edges.Add(new Edge(nodes[1], nodes[4]));
            edges.Add(new Edge(nodes[2], nodes[4]));
            edges.Add(new Edge(nodes[3], nodes[4]));
            Graph testGraph = new Graph(edges, nodes);

            //Print information of the graph
            Console.WriteLine("Inital graph:");
            Console.WriteLine("Nodes:");
            testGraph.Nodes.ToConsole();
            Console.WriteLine("Edges:");
            testGraph.Edges.ToConsole();

            ///
            Hamiltonian hamiltonian = new Hamiltonian(testGraph);
            hamiltonian.hamCycle();
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
