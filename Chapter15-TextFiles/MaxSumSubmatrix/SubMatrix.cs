using System;
using System.IO;

namespace Exercise05
{
    /// <summary>
    /// Write a program that reads a square matrix of integers from a file and finds the sub-matrix with size 2 × 2 that has the maximal sum and writes this sum to a separate text file.
    /// The first line of input file contains the size of the recorded matrix (N).
    /// The next N lines contain N integers separated by spaces.
    /// </summary>
    internal class SubMatrix
    {
        private static void Main(string[] args)
        {
            string sourceFolder = Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\";
            string sourceFile = Path.Combine(sourceFolder, "Exercise05.txt");
            string outputFile = Path.Combine(sourceFolder, "Exercise05out.txt");
            int[,] matrix;
            int maxSum;
            try
            {
                using (StreamReader streamReader = new StreamReader(sourceFile))
                {
                    string line = streamReader.ReadLine();
                    string[] lineElements;
                    int n = Int32.Parse(line);
                    matrix = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        line = streamReader.ReadLine();
                        lineElements = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < n; j++)
                        {
                            matrix[i, j] = Int32.Parse(lineElements[j]);
                        }
                    }
                    maxSum = GetMaxSubmatrixSum(matrix);
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        Console.WriteLine(Environment.NewLine);
                    }
                }
                using (StreamWriter streamWriter = new StreamWriter(outputFile, false))
                {
                    streamWriter.WriteLine(maxSum);
                }
            }
            catch (Exception)
            {
                throw;
            }
            Console.WriteLine($"Max 2x2 submatrix sum is: {maxSum}");
            Console.ReadKey();
        }

        /// <summary>
        /// Get max 2x2 submatrix sum
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int GetMaxSubmatrixSum(int[,] matrix)
        {
            int nCount = matrix.GetLength(0); // number of row and column (matrix n*n)
            int submatrixSum;
            int maxSum = 0;

            for (int i = 0; i < nCount - 1; i++)
            {
                for (int j = 0; j < nCount - 1; j++)
                {
                    submatrixSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (submatrixSum > maxSum) { maxSum = submatrixSum; }
                }
            }
            return maxSum;
        }
    }
}