using Chapter_05.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_09.Traversal
{
	public class BreadthFirstSearch
	{
		//Iterative
		public List<int> BreadthFSearch(Node currentNode)
		{
			List<int> list = new List<int>();
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(currentNode);
			while (queue.Count > 0)
			{
				currentNode = queue.Dequeue();
				list.Add(currentNode.Value);
				if (currentNode.Left != null)
				{
					queue.Enqueue(currentNode.Left);
				}
				if (currentNode.Right != null)
				{
					queue.Enqueue(currentNode.Right);
				}
			}
			return list;
		}
		//Recursive 
		public List<int> BreadthFirstRecursive(Queue<Node> queue, List<int> list)
		{
			if (queue.Count == 0)
			{
				return list;
			}
			var currentNode = queue.Dequeue();
			list.Add(currentNode.Value);
			if (currentNode.Left != null)
			{
				queue.Enqueue(currentNode.Left);
			}
			if (currentNode.Right != null)
			{
				queue.Enqueue(currentNode.Right);
			}
			return BreadthFirstRecursive(queue, list);
		}
	}
}

