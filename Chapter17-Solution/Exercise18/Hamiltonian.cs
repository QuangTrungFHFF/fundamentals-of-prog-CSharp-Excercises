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
        public bool IsSafe(Node v,int pos)
        {
            bool isAdj = false;
            bool isAdded = false;
            //Check if this vertex is an adjacent vertex of the previously added vertex.
            foreach(Edge adj in v.Edges)
            {
                if(adj.Neighbor.Contains(Path[pos-1]))
                {
                    isAdj = true;
                }
            }
            // Check if the vertex has already been included. This step can be optimized by creating an array of size V
            for (int i = 0; i < pos; i++)
            {
                if (Path[i] == v)
                {
                    isAdded = true;
                }
            }
            if(isAdj&&!isAdded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// A recursive utility function to solve hamiltonian cycle problem
        /// </summary>
        /// <returns></returns>
        bool HamiltonianCycleUtil(int pos)
        {
            // base case: If all vertices are included in Hamiltonian Cycle 
            if(pos == Size)
            {
                // And if there is an edge from the last included 
                // vertex to the first vertex 
                foreach (Edge adj in Path[pos-1].Edges)
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
            // Try different vertices as a next candidate in 
            // Hamiltonian Cycle. We don't try for 0 as we 
            // included 0 as starting point in hamCycle()
            for(int v =1; v<Size; v++)
            {
                /* Check if this vertex can be added to Hamiltonian Cycle */
                if(this.IsSafe(Graph.Nodes[v],pos))
                {
                    Path[pos] = Graph.Nodes[v];

                    /* recur to construct rest of the path */
                    if(HamiltonianCycleUtil(pos+1) == true)
                    {
                        return true;
                    }
                    /* If adding vertex v doesn't lead to a solution, then remove it */
                    Path[pos] = null;
                }
            }
            /* If no vertex can be added to Hamiltonian Cycle constructed so far, then return false */
            return false;
        }
        /* This function solves the Hamiltonian Cycle problem using Backtracking. It mainly uses hamCycleUtil() to solve the problem.
         * It returns false if there is no Hamiltonian Cycle possible, otherwise return true and prints the path.\
         *  Please note that there may be more than one solutions, this function prints one of the feasible solutions. */
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
        void PrintSolution()
        {
            Console.WriteLine("Solution Exists: Following" +
                            " is one Hamiltonian Cycle");
            for (int i = 0; i < Size; i++)
                Console.Write(" " + Path[i].ToString() + " ");

            // Let us print the first vertex again 
            //  to show the complete cycle 
            Console.WriteLine(" " + Path[0].ToString() + " ");
        }
    }
}