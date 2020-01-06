using MsdnDirectedGraph;
using System;
using System.Collections.Generic;

namespace Exercise16
{
    internal class TestProgram
    {
        /// <summary>
        /// We have N tasks to be performed successively. We are given a list of pairs of tasks for which the second is dependent on the outcome of the first and should be executed after it.
        /// Write a program that arranges tasks in such a way that each task is be performed after all the tasks which it depends on have been completed.
        /// </summary>
        /// <param name="args"></param>
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

            //Add Edge to nodes. (Each edge represents a pairs of tasks)
            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(nodes[5], nodes[0], 1));
            edges.Add(new Edge(nodes[4], nodes[0], 1));
            edges.Add(new Edge(nodes[4], nodes[1], 1));
            edges.Add(new Edge(nodes[5], nodes[2], 1));
            edges.Add(new Edge(nodes[2], nodes[3], 1));
            edges.Add(new Edge(nodes[3], nodes[1], 1));

            Graph testGraph = new Graph(edges, nodes);
            TopologicalSorting sort = new TopologicalSorting(testGraph);
            Console.WriteLine("The order: ");
            sort.PrintStack();
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