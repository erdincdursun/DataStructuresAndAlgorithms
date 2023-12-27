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
         fibonacci.FibonacciRecursive(5);
         Console.WriteLine();
         fibonacci.FibonacciArray(10);

         ReverseString reverseString = new ReverseString();
         Console.WriteLine(reverseString.StringReverse("hello algorithms. ı'm erdinc"));
			Console.WriteLine(reverseString.ReverseStringRecursively("yoyo master"));
         Console.WriteLine(reverseString.ReverseStringIteratively("yoyo master")); 
      }
   }
}
