namespace Chapter_08.SortingAlgorithms;
public class InsertionSort
{
	#region StepByStep
	//int[]numbers = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
	//int[]numbers = { 44, 99, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
	//int[]numbers = { 6, 44, 99, 2, 1, 5, 63, 87, 283, 4, 0 };
	//int[]numbers = { 2, 6, 44, 99, 1, 5, 63, 87, 283, 4, 0 };
	//int[]numbers = { 1, 2, 6, 44, 99, 5, 63, 87, 283, 4, 0 };
	//int[]numbers = { 1, 2, 5, 6, 44, 99, 63, 87, 283, 4, 0 };
	//int[]numbers = { 1, 2, 5, 6, 44, 63, 99, 87, 283, 4, 0 };
	//int[]numbers = { 1, 2, 5, 6, 44, 63, 87, 99, 283, 4, 0 };
	//int[]numbers = { 1, 2, 5, 6, 44, 63, 87, 99, 283, 4, 0 };
	//int[]numbers = { 1, 2, 4, 5, 6, 44, 63, 87, 99, 283, 0 };
	//int[]numbers = { 0,1, 2, 4, 5, 6, 44, 63, 87, 99, 283 };
	#endregion
	public int[] InsertionSortOne(int[] nums) //BigO(n2)
	{
		int length = nums.Length;
		for (int i = 1; i < length; i++)
		{
			int key = nums[i];
			int j = i - 1;
			while (j >= 0 && nums[j] > key)
			{
				nums[j + 1] = nums[j];
				j--;
			}
			nums[j + 1] = key;
		}
		return nums;
	}
}