namespace Chapter_03.LinkedLists;
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
		if (index >= this.Length)
		{
			Append(value);
			return;
		}
		if (index <= 0)
		{
			Prepend(value);
			return;
		}
		Node newNode = new Node(value);
		Node leader = TraversalIndex(index - 1);
		Node holdingPointer = leader.Next;
		leader.Next = newNode;
		newNode.Next = holdingPointer;
		this.Length++;
	}
	private Node TraversalIndex(int index)
	{
		int counter = 0;
		Node currentNode = Head;
		while (counter != index)
		{
			currentNode = currentNode.Next;
			counter++;
		}
		return currentNode;
	}
	public void Reverse()
	{
		if (this.Head.Next == null)
		{
			PrintList();
		}
		Node first = this.Head;
		this.Tail = this.Head;
		Node second = first.Next;
		for (int i = 0; i < Length - 1; i++)
		{
			Node temp = second.Next;
			second.Next = first;
			first = second;
			second = temp;
		}
		this.Head.Next = null;
		this.Head = first;
	}
	public void Remove(int index)
	{
		if (index == 0)
		{
			Head = Head.Next;
			return;
		}
		Node leader = TraversalIndex(index - 1);
		Node nodeToRemove = leader.Next;
		leader.Next = nodeToRemove.Next;
		this.Length--;
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

