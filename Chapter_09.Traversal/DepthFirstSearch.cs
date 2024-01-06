using Chapter_05.Trees;
using Microsoft.Graph.Education.Classes.Item.Assignments.Item.Submissions.Item.Return;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_09.Traversal
{
	public class DepthFirstSearch
	{
		CustomBinarySearchTree _tree;

		public List<int> DFSInOrder()
		{
			List<int> result = new List<int>();
			TraverseInOrder(_tree.root, result);
			return result;
		}
		public List<int> DFSPreOrder()
		{
			List<int> result = new List<int>();
			TraversePreOrder(_tree.root, result);
			return result;
		}
		public List<int> DFSPostOrder()
		{
			List<int> result = new List<int>();
			TraversePostOrder(_tree.root, result);
			return result;
		}

		public List<int> TraverseInOrder(Node node, List<int> list)
		{
			if (node.Left != null)
			{
				TraverseInOrder(node.Left, list);
			}
			list.Add(node.Value);
			if (node.Right != null)
			{
				TraverseInOrder(node.Right, list);
			}
			return list;
		}
		public List<int> TraversePreOrder(Node node, List<int> list)
		{
			list.Add(node.Value);
			if (node.Left != null)
			{
				TraversePreOrder(node.Left, list);
			}
			if (node.Right != null)
			{
				TraversePreOrder(node.Left, list);
			}
			return list;
		}
		public List<int> TraversePostOrder(Node node, List<int> list)
		{
			if (node.Left != null)
			{
				TraversePostOrder(node.Left, list);
			}
			if (node.Right != null)
			{
				TraversePostOrder(node.Right, list);
			}
			list.Add(node.Value);
			return list;
		}
	}
}




