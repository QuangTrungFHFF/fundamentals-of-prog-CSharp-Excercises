using System;
using MsdnDirectedGraph;
using System.Collections.Generic;

namespace Exercise13
{
	/// <summary>
	/// Write a program that finds all loops in a directed graph.
	/// Solution by:
	/// Александър Колев Кирев / Веселина Райкова Райкова / Момчил Иванов Стефанов / Николай Евгениев Демирев
	/// </summary>
	class CycleFinding
    {
        static void Main(string[] args)
        {
			Graph graph = new Graph(ReadGraph());

			PrintResult(graph.FindCycles());


		}
		static List<int>[] ReadGraph()
		{
			// Read number of nodes N
			string input = Console.ReadLine();
			int N = int.Parse(input);

			// Read graph as adjacency list
			List<int>[] graph = new List<int>[N];

			for (int i = 0; i < N; i++)
			{
				graph[i] = new List<int>();

				input = Console.ReadLine();
				string[] childs = input.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

				foreach (var child in childs)
				{
					graph[i].Add(int.Parse(child));
				}
			}

			return graph;
		}

		static void PrintResult(List<List<int>> cycles)
		{
			if (cycles.Count == 0)
			{
				Console.WriteLine("No");
			}
			else
			{
				for (int i = 0; i < cycles.Count; i++)
				{
					for (int j = 0; j < cycles[i].Count; j++)
					{
						if (j < cycles[i].Count - 1)
						{
							Console.Write("{0}, ", cycles[i][j]);
						}
						else
						{
							Console.WriteLine("{0}", cycles[i][j]);
						}
					}
				}
			}
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
