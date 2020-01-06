using System;
using System.Linq;
using System.Collections.Generic;
using MsdnDirectedGraph;

namespace Exercise15
{
    /// <summary>
    /// Suppose we are given a weighted oriented graph G (V, E), in which the weights on the side are nonnegative numbers.
    /// Write a program that by a given vertex x from the graph finds the shortest paths from it to all other vertical.
    /// </summary>
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

            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(nodes[0], nodes[1], 3));
            edges.Add(new Edge(nodes[1], nodes[2], 1));
            edges.Add(new Edge(nodes[1], nodes[0], 3));
            edges.Add(new Edge(nodes[2], nodes[1], 1));            

            Graph testGraph = new Graph(edges, nodes);

            //Add new edges to the graph (connecting nodes) 
            testGraph.AddEdge(testGraph.Nodes[0], testGraph.Nodes[5], 8, true);
            testGraph.AddEdge(testGraph.Nodes[0], testGraph.Nodes[6], 17, true);
            testGraph.AddEdge(testGraph.Nodes[1], testGraph.Nodes[6], 24, true);
            testGraph.AddEdge(testGraph.Nodes[2], testGraph.Nodes[4], 3, true);
            testGraph.AddEdge(testGraph.Nodes[2], testGraph.Nodes[5], 2, true);
            testGraph.AddEdge(testGraph.Nodes[4], testGraph.Nodes[3], 10, true);
            testGraph.AddEdge(testGraph.Nodes[3], testGraph.Nodes[5], 5, true);
            testGraph.AddEdge(testGraph.Nodes[3], testGraph.Nodes[6], 6, true);

            //Print information of the graph
            Console.WriteLine("Inital graph:");
            Console.WriteLine("Nodes:");
            testGraph.Nodes.ToConsole();
            Console.WriteLine("Edges:");
            testGraph.Edges.ToConsole();

            //Test path finding
            //Find path from node 1 to node 6
            //1-6 => 24
            //1-0-6 =>20
            //1-2-4-3-6 => 20
            //1-2-5-3-6 => 14  (expected this path)
            Dijkstra pathFinding = new Dijkstra();
            pathFinding.GetShortestPathDijkstra(testGraph.Nodes[1], testGraph.Nodes[6]);
            Console.WriteLine("Shortest path from node {0} to node {1} is:", testGraph.Nodes[1], testGraph.Nodes[6]);
            pathFinding.ShortestPath.ToConsole();

        }
    }
    public static class EnumerableHelper
    {
        public static void ToConsole<T>(this IEnumerable<T> enummerable)
        {
            foreach(T item in enummerable)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("");
        }
    }
}
