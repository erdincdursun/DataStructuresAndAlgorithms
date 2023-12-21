namespace Chapter_07.Algorithms
{
   internal class Program
   {
      static void Main(string[] args)
      {
         //Factorial
         //5! = 5*4*3*2*1
         FindFactorialRecursive(5);
         Console.WriteLine(FindFactorialIterative(1));
      }
      //Recursive Solution
      public static int FindFactorialRecursive(int number)
      {
         if (number == 1)
         {
            return 1;
         }
         return number * FindFactorialRecursive(number - 1);
      }
      //While Solution
      public static long FindFactorialIterative(int number)
      {
         if (number == 1)
         {
            return number;
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
      public static long FindFactorialIterativeForLoop(int number)
      {
         long result = 1;
         for (int i = number; i > 0; i--)
         {
            result *= i;
         }
         return result;
      }
   }
}
