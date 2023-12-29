using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_08.SortingAlgorithms
{
	public class MergeSort
	{
		public int[] MergeSortOne(int[] array)
		{
			int[] left;
			int[] right;
			int[] result = new int[array.Length];
			if (array.Length <= 1)
			{
				return array;
			}
			int midPoint = array.Length / 2;
			left = new int[midPoint];

			if (array.Length % 2 == 0)
				right = new int[midPoint];
			else
				right = new int[midPoint + 1];

			for (int i = 0; i < midPoint; i++)
			{
				left[i] = array[i];
			}

			int x = 0;
			for (int i = midPoint; i < array.Length; i++)
			{
				right[x] = array[i];
				x++;
			}
			//Recursively sort the left array
			left = MergeSortOne(left);
			//Recursively sort the right array
			right = MergeSortOne(right);
			result = Merge(left, right);
			return result;
		}
		private int[] Merge(int[] left, int[] right)
		{
			int resultLength = left.Length + right.Length;
			int[] result = new int[resultLength];

			int indexLeft = 0; int indexRight = 0; int indexResult = 0;

			while (indexLeft < left.Length || indexRight < right.Length)
			{
            if (indexLeft < left.Length && indexRight < right.Length)
            {
					if (left[indexLeft] < right[indexRight])
					{
						result[indexResult] = left[indexLeft];
						indexLeft++;
						indexResult++;
					}
					else
					{
						result[indexResult] = right[indexRight];
						indexRight++;
						indexResult++;
					}
            }
				else if (indexLeft < left.Length)
				{
					result[indexResult] = left[indexLeft];
					indexLeft++;
					indexResult++;
				}
				else if(indexRight < right.Length)
				{
					result[indexResult] = right[indexRight];
					indexRight++;
					indexResult++;
				}
         }
			return result;
		}
	}
}
