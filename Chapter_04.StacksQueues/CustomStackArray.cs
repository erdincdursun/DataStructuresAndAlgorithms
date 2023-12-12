using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04.StacksQueues
{
    public class CustomStackArray
    {
        private ArrayList Array;
        public CustomStackArray()
        {
            this.Array = new ArrayList();
        }

        public Object Peek()
        {
            if (this.Array.Count > 0)
                return this.Array[this.Array.Count - 1];
            return -100000; //returning -100000 if length is 0
        }
        public void Push(Object value)
        {
            this.Array.Add(value);
        }
        public Object Pop()
        {
            if (this.Array.Count == 0)
            {
                return -100000;
            }
            var lastItem = this.Array[this.Array.Count - 1];
            this.Array.RemoveAt(this.Array.Count - 1);
            return lastItem;
        }
        public void PrintStack()
        {
            for (int i = this.Array.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(this.Array[i]);
            }
        }
    }
}
