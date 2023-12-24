using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_07.Algorithms
{
   public class ReverseString
   {
      public string StringReverse(string text)
      {
         string newText = string.Empty;
         for (int i = text.Length-1; i >= 0; i--)
         {
            newText += text[i];
         }
         return newText;
      }
      public String ReverseStringIteratively(string str)
      {
         StringBuilder result = new StringBuilder();
         for (int i = 0; i < str.Length; i++)
         {
            result.Append(str[str.Length - 1 - i]);
         }
         return result.ToString();
      }
      public String ReverseStringRecursively(string str)
      {
         if (str.Length == 0)
         {
            return "";
         }
         return ReverseStringRecursively(str.Substring(1)) + str[0];
      }
   }
}
