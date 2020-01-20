using System;
using System.Collections.Generic;
using System.Text;
using MsdnDirectedGraph;

namespace Exercise13
{
	/// <summary>
	/// 
	/// </summary>
	class Graph
	{
		private List<int>[] childNodes;
		private List<List<int>> cycles;

		public Graph(List<int>[] childNodes)
		{
			this.childNodes = childNodes;
			this.cycles = new List<List<int>>();
		}

		public int NodesCount
		{
			get { return childNodes.Length; }
		}

		public List<List<int>> FindCycles()
		{
			for (int node = 0; node < childNodes.Length; node++)
			{
				List<int> path = new List<int>();
				path.Add(node);
				ProcessPaths(node, path);
			}

			return this.cycles;
		}

		private void ProcessPaths(int current, List<int> path)
		{
			foreach (var node in childNodes[current])
			{
				if (node == path[0])
				{
					path.Add(node);
					if (!IsAlreadyFound(path))
					{
						cycles.Add(new List<int>(path));
					}
					path.RemoveAt(path.Count - 1);
					return;
				}
				else if (!path.Contains(node))
				{
					path.Add(node);
					ProcessPaths(node, path);
					path.RemoveAt(path.Count - 1);
				}
			}
		}

		private bool IsAlreadyFound(List<int> foundCycle)
		{
			List<int> reversed = new List<int>(foundCycle);
			reversed.Reverse();

			foreach (var cycle in cycles)
			{
				if (CompareLists(cycle, foundCycle) || CompareLists(cycle, reversed))
				{
					return true;
				}
			}

			return false;
		}

		private bool CompareLists(List<int> first, List<int> second)
		{
			if (first.Count != second.Count)
			{
				return false;
			}

			for (int i = 0; i < first.Count; i++)
			{
				if (first[i] != second[i])
				{
					return false;
				}
			}

			return true;


		}
	}
}
