namespace Chapter_03.LinkedLists
{
	public class LinkedList
	{
		private Node Head;
		private Node Tail;
		private int Length;

		public LinkedList(int value)
		{
			this.Head = new Node(value);
			this.Tail = this.Head;
			this.Length = 1;
		}
		
		public void Append(int value)
		{
			Node newNode = new Node(value);
			this.Tail.Next = newNode;
			this.Tail = newNode;
			this.Length++;	
		}

		public void Prepend(int value)
		{
			Node newNode = new Node(value);
			newNode.Next = this.Head;
			this.Head = newNode;
			this.Length++;
		}
	}
}
