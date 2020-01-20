using MsdnUnDirectedGraph;
using System;

namespace Exercise18
{
    internal class Hamiltonian
    {
        public Graph Graph { get; private set; }
        public int Size { get; private set; }
        public Node[] Path { get; set; }

        public Hamiltonian(Graph graph)
        {
            this.Graph = graph;
            this.Size = graph.Nodes.Count;
            this.Path = new Node[Size];
        }

        /// <summary>
        /// A utility function to check if the vertex v can be added at index 'pos'in the Hamiltonian Cycle constructed so far(stored in 'path[]')
        /// </summary>
        /// <param name="v"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public bool IsSafe(Node v, int pos)
        {
            bool isAdj = false;
            bool isAdded = false;
            //Check if this node and the previously added vertex are connected.
            foreach (Edge adj in v.Edges)
            {
                if (adj.Neighbor.Contains(Path[pos - 1]))
                {
                    isAdj = true;
                }
            }
            // Check if the node has already been added to the path.
            for (int i = 0; i < pos; i++)
            {
                if (Path[i] == v)
                {
                    isAdded = true;
                }
            }
            //If a node is adj with previous node and not already in the path, then it's safe to add
            if (isAdj && !isAdded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// A recursive method function to solve hamiltonian cycle problem
        /// </summary>
        /// <returns></returns>
        private bool HamiltonianCycleUtil(int pos)
        {
            //If all nodes of the graph are added in the path
            if (pos == Size)
            {
                // Check if this Halminton path is a Halminton Cycle (check if first node and last node share an edge
                foreach (Edge adj in Path[pos - 1].Edges)
                {
                    if (adj.Neighbor.Contains(Path[0]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            // Node 0 always in the first pos of the path. Try to add the next node to the path
            for (int v = 1; v < Size; v++)
            {
                // Check if this node can be added to the path
                if (this.IsSafe(Graph.Nodes[v], pos))
                {
                    Path[pos] = Graph.Nodes[v];

                    // Construct rest of the path
                    if (HamiltonianCycleUtil(pos + 1) == true)
                    {
                        return true;
                    }
                    // If there's no solution found after adding a node, then remove that node and try again
                    Path[pos] = null;
                }
            }
            // If this code run to this point, we failed to find a solution
            return false;
        }

        // Add first node to the path. check if we can find a solution. then print the solution
        public void hamCycle()
        {
            Path[0] = Graph.Nodes[0];
            if (HamiltonianCycleUtil(1) == false)
            {
                Console.WriteLine("\nSolution does not exist");
            }
            else
            {
                PrintSolution();
            }
        }

        private void PrintSolution()
        {
            Console.WriteLine("Found a solution!");
            for (int i = 0; i < Size; i++)
            {
                Console.Write(" " + Path[i].ToString() + " ");
            }                
            Console.WriteLine(" " + Path[0].ToString() + " ");
        }
    }
}