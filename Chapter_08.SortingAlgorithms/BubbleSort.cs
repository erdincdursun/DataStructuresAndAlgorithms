using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_08.SortingAlgorithms
{
	public class BubbleSort
	{
		//int[]numbers = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
		public int[] BubbleSortOne(int[] nums) //BigO(n2)
		{
			int length = nums.Length;
			int temp;
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length - 1; j++)
				{
					if (nums[j] > nums[j + 1])
					{
						temp = nums[j];
						nums[j] = nums[j + 1];
						nums[j + 1] = temp;
					}
				}
			}
			return nums;
		}
	}
}


