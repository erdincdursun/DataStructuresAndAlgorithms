namespace Chapter_03.LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Singly Linked List \n");

            LinkedList newList = new LinkedList(10);
            newList.Append(5);
            newList.Append(16);
            newList.Prepend(1);
            newList.Insert(2, 99);
            newList.Remove(2);
            newList.Reverse();
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
}
