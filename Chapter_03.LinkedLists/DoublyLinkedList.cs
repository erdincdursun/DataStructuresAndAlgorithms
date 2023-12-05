using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_03.LinkedLists
{
    public class DoublyLinkedList
    {
        private DoublyNode Head;
        private DoublyNode Tail;
        private int Length;

        public DoublyLinkedList(Object value)
        {
            this.Head = new DoublyNode(value);
            this.Tail = this.Head;
            this.Length = 1;
        }
        public void Append(Object value)
        {
            DoublyNode doublyNode = new DoublyNode(value);
            doublyNode.Previous = this.Tail;
            this.Tail.Next = doublyNode;
            this.Tail = doublyNode;
            this.Length++;
        }
        public void Prepend(Object value)
        {
            DoublyNode doublyNode = new DoublyNode(value);
            doublyNode.Next = this.Head;
            this.Head.Previous = doublyNode;
            this.Head = doublyNode;
            this.Length++;

        }
        public void Insert(int index, Object value)
        {
            if (index == 0)
            {
                Prepend(value);
                return;
            }
            if (index >= this.Length)
            {
                Append(value);
                return;
            }
            DoublyNode newNode = new DoublyNode(value);
            DoublyNode leader = TraversalIndex(index - 1);
            DoublyNode follower = leader.Next;
            leader.Next = newNode;
            newNode.Previous = leader;
            newNode.Next = follower;
            follower.Previous = newNode;
            this.Length++;
        }
        private DoublyNode TraversalIndex(int index)
        {
            int count = 0;
            DoublyNode currentNode = this.Head;
            while (count != index)
            {
                currentNode = currentNode.Next;
                count++;
            }
            return currentNode;
        }

        public void Remove(int index)
        {
            DoublyNode leader = TraversalIndex(index - 1);
            DoublyNode removeNode = leader.Next;
            leader.Next = removeNode.Next;
            removeNode.Next.Previous = leader;
            this.Length--;
        }

        public void PrintList()
        {
            if (this.Head == null) return;
            DoublyNode currentNode = this.Head;
            while (currentNode != null)
            {
                Console.Write("--->" + currentNode.Value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}
