using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04.StacksQueues
{
    public class Node
    {
        public Object Value { get; set; }
        public Node Next { get; set; }

        public Node(Object value)
        {
            Value = value;
            Next = null;
        }
    }
}
