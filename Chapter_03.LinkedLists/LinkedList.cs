using System.Runtime.CompilerServices;

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
   public bool InsertBool(int index, int value)
   {
      if (index < 0 || index >= Length) return false;
      if (index == 0)
      {
         Prepend(value);
         return true;
      }
      if (index == Length)
      {
         Append(value);
         return true;
      }
      Node newNode = new Node(value);
      Node temp = Get(index - 1);
      newNode.Next = temp.Next;
      temp.Next = newNode;
      this.Length++;
      return true;
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

   public void Reverse2()
   {
      Node temp = Head;
      Head = Tail;
      Tail = temp;

      Node after = temp.Next;
      Node before = null;

      for (int i = 0; i < Length; i++)
      {
         after = temp.Next;
         temp.Next = before;
         before = temp;
         temp = after;
         
      }
   }
   public Node RemoveLast()
   {
      if (Length == 0) return null;
      Node temp = Head;
      Node prev = Head;
      while (temp.Next != null)
      {
         prev = temp;
         temp = temp.Next;
      }
      Tail = prev;
      Tail.Next = null;
      Length--;
      if (Length == 0)
      {
         Head = null;
         Tail = null;
      }
      return temp;
   }
   public Node RemoveFirst()
   {
      if (Length == 0) return null;
      Node temp = Head;
      Head = temp.Next;
      temp.Next = null;
      Length--;
      if (Length == 0)
      {
         Head = null;
         Tail = null;
      }
      return temp;
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
   public Node Remove2(int index)
   {
      if (index < 0 || index >= Length) return null;
      if (index == 0) return RemoveFirst();
      if (index == Length - 1) return RemoveLast();

      Node prev = Get(index - 1);
      Node temp = prev.Next;

      prev.Next = temp.Next;
      temp.Next = null;
      Length--;
      return temp;
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
   public Node Get(int index)
   {
      if (index < 0 || index >= Length) return null;
      Node temp = Head;
      for (int i = 0; i < index; i++)
      {
         temp = temp.Next;
      }
      return temp;
   }
   public bool Set(int index, int value)
   {
      Node temp = Get(index);
      if (temp != null)
      {
         temp.Value = value;
         return true;
      }
      return false;
   }
   public Node FindMiddleNode()
   {
      Node slow = Head;
      Node fast = Head;

      while(fast is not null && fast.Next is  not null)
      {
         slow = slow.Next;
         fast = fast.Next.Next;
      }
      return slow;
   }


}