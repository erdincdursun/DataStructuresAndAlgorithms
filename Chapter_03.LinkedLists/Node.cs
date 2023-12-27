namespace Chapter_03.LinkedLists;
public class Node
{
	public Object Value { get; set; }
	public Node Next { get; set; }
	public Node(Object value)
	{
		this.Value = value;
		this.Next = null;
	}
}

