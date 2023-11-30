using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_01.CustomArrayClass
{
	public class MergeSortedArrays
	{
	
		//1.Solution
		public int[] MergeSortedArray(int[]arrayOne , int[]arrayTwo)
		{
			int[] mergeArray = arrayOne.Concat(arrayTwo).ToArray();
			Array.Sort(mergeArray);
			return mergeArray;
		}

		//2.Solution
		// arrayOne[0,3,4,31] ,   arrayTwo[4,6,30];
		// arrayResult[0,3,4,4,6,30,31];
		public void MergeArrays(int[] array1, int[] array2, int size1, int size2, int[] array3)
		{
			int i = 0, j = 0, k = 0;

			while (i < size1 && j < size2)
			{
				if (array1[i] < array2[j])
					array3[k++] = array1[i++];
				else
					array3[k++] = array2[j++];
			}

			while (i < size1)
				array3[k++] = array1[i++];

			while (j < size2)
				array3[k++] = array2[j++];
		}
	}

}
