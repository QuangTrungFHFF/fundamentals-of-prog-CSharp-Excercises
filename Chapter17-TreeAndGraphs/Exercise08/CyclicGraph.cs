using System;
using MsdnDirectedGraph;
using System.Collections.Generic;

namespace Exercise08
{
    /// <summary>
    /// Let’s have as given a graph G(V, E). Write a program that checks whether the graph is cyclic.
    /// </summary>
    class CyclicGraph
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

            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(nodes[0], nodes[1], 1));            
            edges.Add(new Edge(nodes[1], nodes[2], 1));
            edges.Add(new Edge(nodes[2], nodes[3], 1));
            edges.Add(new Edge(nodes[3], nodes[4], 1));
            edges.Add(new Edge(nodes[4], nodes[0], 1));

            Graph testGraph = new Graph(edges, nodes);

            //Print information of the graph
            Console.WriteLine("Inital graph:");
            Console.WriteLine("Nodes:");
            testGraph.Nodes.ToConsole();
            Console.WriteLine("Edges:");
            testGraph.Edges.ToConsole();
            
            if(IsCycle(testGraph))
            {
                Console.WriteLine("The graph is cycle!");
            }
            else
            {
                Console.WriteLine("The graph is not cycle!");
            }
        }
        /// <summary>
        /// Check if a node is repeated, if no node is repeated then it's not a cycle graph
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static bool IsCycle(Graph graph)
        {
            bool isRepeated = false;
            Node currentNode = graph.Nodes[1];
            var nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(currentNode);
            while(isRepeated!= true && nodeQueue.Count>0)
            {
                currentNode = nodeQueue.Dequeue();
                if(currentNode.Visited == false)
                {
                    currentNode.Visited = true;
                    foreach(Edge e in currentNode.OutboundEdges)
                    {
                        nodeQueue.Enqueue(e.To);
                    }
                }
                else
                {
                    isRepeated = true;
                }
                
            }
            return isRepeated;

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
