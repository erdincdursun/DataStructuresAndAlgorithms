using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10.DynamicProgramming
{
	public class Fibonacci_DP
	{
		private Dictionary<int, int> cache = new Dictionary<int, int>();

		public int FibonacciMaster(int n)
		{
			if (cache.ContainsKey(n))
			{
				return cache[n];
			}
			if (n < 2)
			{
				return n;
			}
			cache.Add(n, FibonacciMaster(n - 1) + FibonacciMaster(n - 2));
			return cache[n];
		}
	}
}
