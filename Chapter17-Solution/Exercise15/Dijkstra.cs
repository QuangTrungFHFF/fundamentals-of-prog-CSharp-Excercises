using System;
using System.Collections.Generic;
using System.Text;
using MsdnDirectedGraph;
using System.Linq;

namespace Exercise15
{
    class Dijkstra
    {
        public List<Node> ShortestPath { get; private set; }
        public Dijkstra()
        {
            this.ShortestPath = new List<Node>();
        }
        public void GetShortestPathDijkstra(Node start, Node end)
        {
            DijkstraSearch(start, end);
            ShortestPath.Add(end);
            BuildShortestPath(ShortestPath, end);
            ShortestPath.Reverse();            
        }
        private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.NearestToStart == null)
            {
                return;
            }
            list.Add(node.NearestToStart);
            BuildShortestPath(list, node.NearestToStart);
        }

        private void DijkstraSearch(Node start, Node end)
        {
            start.MinCostToStart = 0;
            var prioQueue = new List<Node>();
            prioQueue.Add(start);
            do
            {
                prioQueue = prioQueue.OrderBy(x => x.MinCostToStart).ToList();
                var node = prioQueue.First();
                prioQueue.Remove(node);
                foreach (var cnn in node.OutboundEdges.OrderBy(x => x.Distance))
                {
                    var childNode = cnn.To;
                    if (childNode.Visited)
                    {
                        continue;
                    }
                    if (childNode.MinCostToStart == null || node.MinCostToStart + cnn.Distance < childNode.MinCostToStart)
                    {
                        childNode.MinCostToStart = node.MinCostToStart + cnn.Distance;
                        childNode.NearestToStart = node;
                        if (!prioQueue.Contains(childNode))
                        {
                            prioQueue.Add(childNode);
                        }
                    }
                }
                node.Visited = true;
                if (node == end)
                    return;
            } while (prioQueue.Any());
        }
    }
}
