namespace Chapter_03.LinkedLists
{
	public class LinkedList
	{
		private Node Head;
		private Node Tail;
		private int Length;

		public LinkedList(Object value)
		{
			this.Head = new Node(value);
			this.Tail = this.Head;
			this.Length = 1;
		}

		public void Append(Object value)
		{
			Node newNode = new Node(value);
			this.Tail.Next = newNode;
			this.Tail = newNode;
			this.Length++;
		}

		public void Prepend(Object value)
		{
			Node newNode = new Node(value);
			newNode.Next = this.Head;
			this.Head = newNode;
			this.Length++;
		}
		public void PrintList()
		{
			if (this.Head == null) return;
			Node current = this.Head;
			while (current != null)
			{
				Console.Write("--->" + current.Value);
				current = current.Next;
			}
			Console.WriteLine();
		}

		public void Insert(int index, Object value)
		{
			index = WrapIndex(index);
			if (index == 0)
			{
				Prepend(value);
				return;
			}
			if (index == this.Length - 1)
			{
				Append(value);
				return;
			}
			Node newNode = new Node(value);
			Node Leader = TraversalIndex(index-1);
			Node holdingPointer = Leader.Next;
			Leader.Next = newNode;
			newNode.Next = holdingPointer;
			this.Length++;

		}

		private int WrapIndex(int index)
		{
			return Math.Max(Math.Min(index, this.Length - 1), 0);
		}
		
		private Node TraversalIndex(int index)
		{
			int count = 0;
			index = WrapIndex(index);
			Node currentNode = Head;
			while (count != index)
			{
				currentNode = currentNode.Next;
				count++;
			}
			return currentNode;
		}

		public int GetLength()
		{
			return this.Length;
		}
		public Node GetHead()
		{
			return this.Head;
		}
		public Node GetTail()
		{
			return this.Tail;
		}

	}
}
