using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_03.LinkedLists
{
    public class DoublyNode
    {
        public Object Value { get; set; }
        public DoublyNode Next { get; set; }
        public DoublyNode Previous { get; set; }

        public DoublyNode(Object value)
        {
            this.Value = value;
            this.Next = null;
            this.Previous = null; 
        }
    }
}
