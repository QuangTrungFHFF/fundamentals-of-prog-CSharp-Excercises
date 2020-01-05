using System;
using System.Collections.Generic;
using System.Text;
using MsdnDirectedGraph;

namespace Exercise09
{
    class TraversalPath
    {
        public Graph Graph { get; private set; }        
        public List<Node> TraversalInDepthPath { get; private set; }
        public TraversalPath(Graph graph)
        {
            this.Graph = graph;
            TraversalInDepthPath = new List<Node>();
            this.TraversalPathRecursive(graph.Nodes[0],false);
        }
        /// <summary>
        /// Using recursive DFS to find all nodes
        /// </summary>
        /// <param name="node"></param>
        /// <param name="visited"></param>
        public void TraversalPathRecursive(Node node, bool visited)
        {
            if(!node.Visited)
            {
                node.Visited = true;
                TraversalInDepthPath.Add(node);
                foreach(Edge n in node.OutboundEdges)
                {
                    TraversalPathRecursive(n.To, n.To.Visited);
                }
            }
        }
    }
}
