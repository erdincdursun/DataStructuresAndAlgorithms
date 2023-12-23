using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_07.Algorithms
{
   public class Fibonacci
   {
      //1 1 2 3 5 8 13 21 34
      public int FibonacciRecursive(int n) // O(2^n)
      {
         if (n < 2)
         {
            return n;
         }
         return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
      }
      public void FibonacciIterative(int n)
      {
         int number1 = 1;
         int number2 = 1;
         int number3;

         if (n < 2)
         {
            Console.WriteLine(n);
            return;
         }
         Console.Write(number1 + " ");
         Console.Write(number2 + " ");
         for (int i = 2; i < n; i++)
         {
            number3 = number1 + number2;
            number1 = number2;
            number2 = number3;
            Console.Write(number3 + " ");
         }
      }
      public void FibonacciArray(int n)
      {
         long[] fibonacci = new long[n];
         fibonacci[0] = 1;
         fibonacci[1] = 1;
         for (int i = 2; i < n; i++)
         {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
         }
         for (int i = 0; i < n; i++)
         {
            Console.Write(fibonacci[i] + " ");
         }
      }
      

      public int RecursiveFibonacci(int n)
      {
         if (n<2)
         {
            return n;
         }
         return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
      }

   }
}
