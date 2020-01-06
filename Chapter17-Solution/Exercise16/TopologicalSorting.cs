using MsdnDirectedGraph;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise16
{
    internal class TopologicalSorting
    {
        public Stack<Node> TopologicalStack { get; private set; }
        public List<Node> Graph { get; private set; }
        private bool isPossible = false;

        public TopologicalSorting(Graph graph)
        {
            this.Graph = new List<Node>();
            SortGraphByDependance(graph);
            TopologicalStack = new Stack<Node>();
            this.IsCycle(graph);
            if (this.isPossible)
            {
                this.Sorting();
            }
        }

        /// <summary>
        /// Sort the given graph by number of nodes it depends on
        /// </summary>
        /// <param name="graph"></param>
        private void SortGraphByDependance(Graph graph)
        {
            foreach (Node n in graph.Nodes)
            {
                this.Graph.Add(n);
            }
            this.Graph = this.Graph.OrderBy(x => x.OutboundEdges.Count).ToList();
        }

        /// <summary>
        /// Sort all nodes in the graph
        /// </summary>
        private void Sorting()
        {
            int size = Graph.Count;
            Node current;
            for (int i = 0; i < size; i++)
            {
                current = Graph[i];
                if (!current.Visited)
                {
                    TopologicalSort(current);
                }
            }
        }

        /// <summary>
        /// Recursive mothod to create stack of nodes
        /// </summary>
        /// <param name="node"></param>
        private void TopologicalSort(Node node)
        {
            if (!node.Visited)
            {
                node.Visited = true;

                foreach (Edge e in node.OutboundEdges)
                {
                    TopologicalSort(e.To);
                }
                TopologicalStack.Push(node);
            }
        }

        /// <summary>
        /// Topological Sorting for a graph is not possible if the graph is not a Directed Acyclic Graph. This method check if the graph is a cyclic or acyclic graph.
        /// </summary>
        /// <param name="graph"></param>
        public void IsCycle(Graph graph)
        {
            bool isRepeated = false;
            Node currentNode = graph.Nodes[1];
            var nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(currentNode);
            while (isRepeated != true && nodeQueue.Count > 0)
            {
                currentNode = nodeQueue.Dequeue();
                if (currentNode.Visited == false)
                {
                    currentNode.Visited = true;
                    foreach (Edge e in currentNode.OutboundEdges)
                    {
                        nodeQueue.Enqueue(e.To);
                    }
                }
                else
                {
                    isRepeated = true;
                }
            }
            if (!isRepeated)
            {
                this.isPossible = true;
            }
        }

        public void PrintStack()
        {
            if (isPossible)
            {
                var cloneStack = new Stack<Node>(this.TopologicalStack);
                var rightOrder = new List<Node>();
                while (cloneStack.Count > 0)
                {
                    rightOrder.Add(cloneStack.Pop());
                }
                rightOrder.Reverse();
                foreach (Node n in rightOrder)
                {
                    Console.Write(n.ToString() + " ");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Such order is not exist because the graph is cycle!");
            }
        }
    }
}