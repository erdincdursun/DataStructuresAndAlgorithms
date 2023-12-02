namespace Chapter_03.LinkedLists
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LinkedList newList = new LinkedList(10);
			newList.Append(5);
			newList.Append(16);
			newList.Prepend(1);
			newList.Insert(20,99);
			newList.PrintList();

		}
	}
}
