namespace Chapter_05.Trees;
internal class Program
{
	static void Main(string[] args)
	{
		CustomBinarySearchTree customBinarySearchTree = new CustomBinarySearchTree();
		customBinarySearchTree.Insert(9);
		customBinarySearchTree.Insert(4);
		customBinarySearchTree.Insert(6);
		customBinarySearchTree.Insert(20);
		customBinarySearchTree.Insert(170);
		customBinarySearchTree.Insert(15);
		customBinarySearchTree.Lookup(20);
		customBinarySearchTree.Remove(170);
		customBinarySearchTree.printTree(customBinarySearchTree.root);
	}
}
