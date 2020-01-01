using System;
using System.Collections.Generic;


namespace Exercise18
{
    /// <summary>
    /// We are given a labyrinth of size N x N. Some of the cells of the labyrinth are empty (0), and others are filled (x).
    /// We can move from an empty cell to another empty cell, if the cells are separated by a single wall.
    /// We are given a start position (*). Calculate and fill the labyrinth as follows: in each empty cell put the minimal distance from the start position to this cell.
    /// If some cell cannot be reached, fill it with "u".
    /// </summary>
    class MatrixFill
    {
        static void Main(string[] args)
        {
            string[,] matrix = new string[,] { {"0","0","0","x","0","x"},
                                               {"0","x","0","x","0","x"},
                                               {"0","a","x","0","x","0"},
                                               {"0","x","0","0","0","0"},
                                               {"0","0","0","x","x","0"},
                                               {"0","0","0","x","0","x"} };
            
            PathFinding markedMatrix = new PathFinding(matrix);            
            string[,] newMatrix = markedMatrix.MarkMatrix(); 
            for(int i =0; i< newMatrix.GetLength(0);i++)
            {
                for (int j = 0; j< newMatrix.GetLength(1);j++)
                {
                    Console.Write(newMatrix[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
