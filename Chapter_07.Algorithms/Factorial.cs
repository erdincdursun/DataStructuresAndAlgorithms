using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_07.Algorithms
{
   public class Factorial
   {
      //Factorial
      //5! = 5*4*3*2*1

      //Recursive Solution
      public int FindFactorialRecursive(int number)
      {
         if (number == 1)
         {
            return 1;
         }
         return number * FindFactorialRecursive(number - 1);
      }
      //While Solution
      public long FindFactorialIterative(long number)
      {
         if (number == 1)
         {
            return 1;
         }
         long factorial = 1;
         while (number >= 1)
         {
            factorial *= number;
            number--;
         }
         return factorial;
      }
      //For Solution
      public long FindFactorialIterativeForLoop(long number)
      {
         long result = 1;
         for (long i = number; i > 0; i--)
         {
            result *= i;
         }
         return result;
      }

      public long FactorialIterative2(long number)
      {
         if (number == 1 || number == 2)
         {
            return number;
         }
         long factorial = 1;
         while (number > 0)
         {
            factorial *= number;
            number--;
         }
         return factorial;
      }
   }
}
