namespace Chapter_07.Algorithms
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Factorial factorial = new Factorial();
         Console.WriteLine(factorial.FindFactorialRecursive(5));
         Console.WriteLine(factorial.FindFactorialIterative(6));
         Console.WriteLine(factorial.FindFactorialIterativeForLoop(5));

         Fibonacci fibonacci = new Fibonacci();
         fibonacci.FibonacciIterative(10);
         fibonacci.FibonacciRecursive(10);
         Console.WriteLine();
         fibonacci.FibonacciArray(10);
      }
   }
}
