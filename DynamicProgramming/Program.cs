namespace Chapter_10.DynamicProgramming
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Fibonacci_DP dP = new Fibonacci_DP();
         Console.WriteLine(dP.FibonacciMaster(1000));
		}
	}
}
