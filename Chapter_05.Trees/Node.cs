using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_05.Trees;

 public class Node
 {
     public Node Left;
     public Node Right;
     public int Value;
     public Node(int value)
     {
         this.Left = null;
         this.Right = null;
         this.Value = value;
     }
 }
