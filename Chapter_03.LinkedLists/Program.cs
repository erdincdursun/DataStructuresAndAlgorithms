﻿namespace Chapter_03.LinkedLists;
internal class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("\n Singly Linked List \n");

		LinkedList newList = new LinkedList(10);
		newList.Append(5);
		newList.Append(16);
		newList.Append(50);
		newList.Prepend(1);
		newList.Insert(2, 99);
      newList.InsertBool(2, 98);
      //newList.Remove(2);
      //newList.RemoveLast();
      //newList.RemoveFirst();
      Console.WriteLine(newList.Get(2).Value);
		newList.Set(1, 45);
		Console.WriteLine("Orginal: ");
		newList.PrintList();
      Console.WriteLine($"Middle Node : {newList.FindMiddleNode().Value}"); 
		Console.WriteLine("Reverse: ");
		newList.Reverse2();
		//newList.Reverse();
		newList.PrintList();

		Console.WriteLine("\n Doubly Linked List \n");

		DoublyLinkedList doublyLinkedList = new DoublyLinkedList(10);
		doublyLinkedList.Append(5);
		doublyLinkedList.Append(16);
		doublyLinkedList.Prepend(1);
		doublyLinkedList.Insert(2, 99);
		doublyLinkedList.Remove(3);
		doublyLinkedList.PrintList();
	}
}

