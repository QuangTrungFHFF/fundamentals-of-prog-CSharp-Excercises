using System;
using System.Collections.Generic;

namespace Exercise10
{
    /// <summary>
    /// We are given N and M and the following operations:
    ///N = N+1
    ///N = N+2
    ///N = N*2
    ///Write a program, which finds the shortest subsequence from the operations, which starts with N and ends with M.Use queue.
    ///Example: N = 5, M = 16
    ///Subsequence: 5  7  8  16
    ///-------------------------------------------------------------------
    ///Solution by Кирил Попов/Димитър Тачев/Мариан Маринов/Наталия Илиева
    ///-------------------------------------------------------------------
    /// </summary>
    internal class ShortestSubsequence
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter m:");
            int m = int.Parse(Console.ReadLine());
            if (n < 0 || m < 0 || m < n)
            {
                Console.WriteLine("Invalid input data");
                return;
            }
            Queue<Node> nodesList = new Queue<Node>();
            HashSet<int> foundNodes = new HashSet<int>();
            //Create first node
            nodesList.Enqueue(new Node(null, n));

            while (nodesList.Count > 0)
            {
                Node node = nodesList.Dequeue();
                int currentNodeValue = node.Value;

                if (currentNodeValue < m)
                {
                    if (foundNodes.Contains(currentNodeValue + 2) == false)
                    {
                        nodesList.Enqueue(new Node(node, currentNodeValue + 2));
                        foundNodes.Add(currentNodeValue + 2);
                    }
                    if (foundNodes.Contains(currentNodeValue + 1) == false)
                    {
                        nodesList.Enqueue(new Node(node, currentNodeValue + 1));
                        foundNodes.Add(currentNodeValue + 1);
                    }
                    if (foundNodes.Contains(currentNodeValue * 2) == false)
                    {
                        nodesList.Enqueue(new Node(node, currentNodeValue * 2));
                        foundNodes.Add(currentNodeValue * 2);
                    }
                }
                else if (currentNodeValue == m)
                {
                    node.Print();
                    Console.WriteLine("Finished!");
                }
            }
            Console.WriteLine("------------------------");
        }
    }
}