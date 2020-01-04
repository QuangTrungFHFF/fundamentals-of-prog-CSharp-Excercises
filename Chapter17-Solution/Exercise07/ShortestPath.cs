using MsdnDirectedGraph;
using System;
using System.Collections.Generic;
using System.Linq;

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
            GetShortestPath(testGraph.Nodes[1], testGraph.Nodes[4]);
        }

        public static void GetShortestPath(Node nodeX, Node nodeY)
        {
            List<List<Node>> allPath = new List<List<Node>>();
            List<Node> path;
            int shortest = nodeX.Graph.Nodes.Count;
            path = FindPath(nodeX, nodeY, shortest);
            allPath.Add(new List<Node>(path));
            if(path.Count< shortest)
            {
                shortest = path.Count;
            }
            path = FindPath(nodeX, nodeY, shortest);
            if (!IsChecked(path, allPath))
            {
                allPath.Add(new List<Node>(path));
            }

            Console.WriteLine("Here");
            for (int i = 0; i < allPath.Count; i++)
            {
                Console.WriteLine("Path {0}: ",i);
                foreach (Node j in allPath[i])
                {
                    Console.WriteLine(j.ToString() + " ");
                }
            }
            Console.WriteLine("End");
        }
        public static List<Node> FindPath(Node nodeX, Node nodeY,int currentShortest)
        {  
            var nodeStack = new Stack<Node>();
            Node currentNode = nodeX;
            List<Node> path = new List<Node>();
            int count = 0;
            nodeStack.Push(currentNode);
            while (!IsFound(currentNode, nodeY) && nodeStack.Count > 0)
            {
                currentNode = nodeStack.Pop();                
                if (!path.Contains(currentNode))
                {
                    path.Add(currentNode);
                    count++;
                    if(count<currentShortest)
                    {
                        foreach (Edge e in currentNode.OutboundEdges)
                        {
                            if (!currentNode.Equals(e.To))
                            {
                                nodeStack.Push(e.To);
                            }
                        }
                    }
                    
                }
            }
            return path;
        }

        public static bool IsChecked(List<Node> path, List<List<Node>> savedPath)
        {
            for (int i = 0; i < savedPath.Count; i++)
            {
                if (path.SequenceEqual(savedPath[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsFound(Node start, Node end)
        {
            foreach (Edge e in start.OutboundEdges)
            {
                if (e.To == end)
                {
                    return true;
                }
            }
            return false;
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