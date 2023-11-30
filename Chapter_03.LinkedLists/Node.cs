namespace Chapter_03.LinkedLists
{
	public class Node
	{
		public int Value { get; set; }
		public Node Next { get; set; }
		public Node(int value)
		{
			this.Value = value;
			this.Next = null;
		}
	}
}
