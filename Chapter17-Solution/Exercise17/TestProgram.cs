using MsdnUnDirectedGraph;
using System;
using System.Collections.Generic;

namespace Exercise17
{
    internal class TestProgram
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

            //Add new edges to the graph (connecting nodes)
            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(nodes[0], nodes[1]));
            edges.Add(new Edge(nodes[0], nodes[2]));
            edges.Add(new Edge(nodes[0], nodes[4]));
            edges.Add(new Edge(nodes[0], nodes[5]));
            edges.Add(new Edge(nodes[1], nodes[2]));
            edges.Add(new Edge(nodes[1], nodes[4]));
            edges.Add(new Edge(nodes[1], nodes[5]));
            edges.Add(new Edge(nodes[2], nodes[3]));
            edges.Add(new Edge(nodes[2], nodes[5]));
            edges.Add(new Edge(nodes[3], nodes[4]));
            edges.Add(new Edge(nodes[4], nodes[5]));

            Graph testGraph = new Graph(edges, nodes);

            //Print information of the graph
            Console.WriteLine("Inital graph:");
            Console.WriteLine("Nodes:");
            testGraph.Nodes.ToConsole();
            Console.WriteLine("Edges:");
            testGraph.Edges.ToConsole();
            foreach (Node n in testGraph.Nodes)
            {
                Console.WriteLine("Edges of node {0}: ", n.ToString());
                n.Edges.ToConsole();
            }
            if (IsEulerianCycle(testGraph))
            {
                Console.WriteLine("The graph has an Euler loop!");
            }
            else
            {
                Console.WriteLine("The graph does not have an Euler loop!");
            }
        }

        /// <summary>
        /// A connected graph has an Euler cycle if and only if every vertex has even degree.
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        private static bool IsEulerianCycle(Graph graph)
        {
            if (!IsConnectedGraph(graph))
            {
                return false;
            }
            foreach (Node n in graph.Nodes)
            {
                if ((GetDegree(n) % 2 != 0))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Check if all nodes in the graph are connected
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        private static bool IsConnectedGraph(Graph graph)
        {
            var nodeQueue = new Queue<Node>();
            bool correct = true;
            Node current = graph.Nodes[0];
            nodeQueue.Enqueue(current);
            while (nodeQueue.Count > 0)
            {
                current = nodeQueue.Dequeue();
                if (!current.Visited)
                {
                    current.Visited = true;
                    foreach (Edge e in current.Edges)
                    {
                        foreach (Node n in e.Neighbor)
                        {
                            if (!n.Visited)
                            {
                                nodeQueue.Enqueue(n);
                            }
                        }
                    }
                }
            }
            foreach (Node n in graph.Nodes)
            {
                if (!n.Visited)
                {
                    correct = false;
                }
            }
            return correct;
        }

        /// <summary>
        /// Get degree of a node
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private static int GetDegree(Node node)
        {
            return node.Edges.Count;
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