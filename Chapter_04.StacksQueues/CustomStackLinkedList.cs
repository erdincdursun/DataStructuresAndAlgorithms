using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04.StacksQueues
{
    public class CustomStackLinkedList
    {
        private Node Top;
        private Node Bottom;
        public int Length;

        public CustomStackLinkedList()
        {
            this.Top = null;
            this.Bottom = null;
            this.Length = 0;
        }

        public Object Peek()
        {
            if (this.Length > 0)
                return this.Top.Value;
            return -100000; //returning -100000 if length is 0
        }

        public void Push(Object value)
        {
            Node newNode = new Node(value);
            if (this.Length == 0)
            {
                this.Top = newNode;
                this.Bottom = newNode;
            }
            else
            {
                Node holdingPointer = this.Top;
                this.Top = newNode;
                this.Top.Next = holdingPointer;
            }
            this.Length++;
        }

        public Object Pop()
        {
            if (this.Top == null)
            {
                return -100000;
            }
            if (this.Top == this.Bottom)
            {
                this.Bottom = null;
            }
            Node holdingPointer = this.Top;
            this.Top = this.Top.Next;
            this.Length--;
            return holdingPointer.Value;
        }

        public void PrintStack()
        {
            if (Top == null)
            {
                return;
            }
            Node currentNode = Top;
            Console.WriteLine(currentNode.Value);
            while (currentNode != null)
            {
                Console.WriteLine("-->" + currentNode.Value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}
