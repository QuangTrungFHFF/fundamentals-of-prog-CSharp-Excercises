using System;
using MsdnDirectedGraph;
using System.Collections.Generic;

namespace Exercise10
{
    /// <summary>
    /// Write breadth first search (BFS), based on a queue, to traverse a directed graph.
    /// </summary>
    class BFSTraverse
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
            edges.Add(new Edge(nodes[0], nodes[1], 1));
            edges.Add(new Edge(nodes[1], nodes[2], 1));
            edges.Add(new Edge(nodes[1], nodes[0], 1));
            edges.Add(new Edge(nodes[2], nodes[1], 1));

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

            TraverseUsingBFS(testGraph);
        }
        /// <summary>
        /// Using BFS to traverse the graph
        /// </summary>
        /// <param name="graph"></param>
        public static void TraverseUsingBFS(Graph graph)
        {
            //Start with the first node of the graph
            Node currentNode = graph.Nodes[0];
            var nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(currentNode);
            while(nodeQueue.Count>0)
            {
                currentNode = nodeQueue.Dequeue();
                //Check if the node is visited or not
                if(!currentNode.Visited)
                {
                    currentNode.Visited = true;
                    Console.WriteLine(currentNode.ToString() + " ");

                    foreach (Edge e in currentNode.OutboundEdges)
                    {
                        //Check if the next node of the graph already visited or not
                        if(!e.To.Visited)
                        {
                            nodeQueue.Enqueue(e.To);
                        }                        
                    }
                }
                
            }
        }
    }
    public static class EnumerableHelper
    {
        public static void ToConsole<T>(this IEnumerable<T> enumerable)
        {
            foreach(T item in enumerable)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("");
        }
    }
}
