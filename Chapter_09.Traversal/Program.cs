using Chapter_05.Trees;

namespace Chapter_09.Traversal
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CustomBinarySearchTree tree = new CustomBinarySearchTree();
			BreadthFirstSearch breadthSearch = new BreadthFirstSearch();
			tree.Insert(9);
			tree.Insert(4);
			tree.Insert(6);
			tree.Insert(20);
			tree.Insert(170);
			tree.Insert(15);
			tree.Insert(1);

			var result = breadthSearch.BreadthFSearch(tree.root);
			foreach (var item in result)
			{
				Console.Write(item.ToString() + " ");
			}
			Console.WriteLine();

		}
	}
}
