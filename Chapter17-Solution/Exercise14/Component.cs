using MsdnDirectedGraph;
using System.Collections.Generic;

namespace Exercise14
{
    internal class Component
    {
        public int ComponentCount { get; set; }
        public Graph Graph { get; set; }
        public List<List<Node>> AllComponents { get; private set; }

        public Component(Graph graph)
        {
            ComponentCount = 0;
            this.Graph = graph;
            this.AllComponents = this.GetConnectedSubgraphs();
        }

        /// <summary>
        /// Get a list contains all subgraph of the graph
        /// </summary>
        /// <returns></returns>
        public List<List<Node>> GetConnectedSubgraphs()
        {
            var subgraphList = new List<List<Node>>();

            for (int i = 0; i < Graph.Nodes.Count; i++)
            {
                if (!Graph.Nodes[i].Visited)
                {
                    subgraphList.Add(GetSubgraph(Graph.Nodes[i]));
                    this.ComponentCount++;
                }
            }
            return subgraphList;
        }

        /// <summary>
        /// Get list of nodes in a subgraph
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static List<Node> GetSubgraph(Node node)
        {
            var subgraph = new List<Node>();
            var nodeQueue = new Queue<Node>();
            Node current = node;
            nodeQueue.Enqueue(current);
            while (nodeQueue.Count > 0)
            {
                current = nodeQueue.Dequeue();
                if (!current.Visited)
                {
                    current.Visited = true;
                    subgraph.Add(current);
                    foreach (Edge e in current.OutboundEdges)
                    {
                        nodeQueue.Enqueue(e.To);
                    }
                }
            }
            return subgraph;
        }
    }
}