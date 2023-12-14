using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04.StacksQueues
{
    public class CustomQueueLinkedList
    {
        private Node First;
        private Node Last;
        public int length;

        public CustomQueueLinkedList()
        {
            this.First = null;
            this.Last = null;
            this.length = 0;
        }

        public object Peek()
        {
            if (this.length > 0)
            {
                return this.First.Value;
            }
            return -111111;  //returining large negative value if length is 0.
        }
        public void Enqueue(Object value)
        {
            Node newNode = new Node(value);
            if (this.length == 0)
            {
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.Next = newNode;
                this.Last = newNode;
            }
            this.length++;
        }
        public Object Dequeue()
        {
            if (this.First == null)
            {
                return -1111111;
            }
            if (this.length == 0)
            {
                this.Last = null;
            }
            Node holdingPointer = this.First;
            this.First = this.First.Next;
            this.length--;
            return holdingPointer.Value;
        }

        public void PrintList()
        {
            if (First == null)
            {
                return;
            }
            Node currentNode = this.First;
            Console.WriteLine(currentNode.Value);
            currentNode = currentNode.Next;
            while (currentNode != null)
            {
                Console.WriteLine("--->" + currentNode.Value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}
