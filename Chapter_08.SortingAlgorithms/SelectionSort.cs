namespace Chapter_08.SortingAlgorithms;
public class SelectionSort
{
	//int[]numbers = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
	public int[] SelectionSortOne(int[] nums) //BigO(n2)
	{
		int length = nums.Length;
		int temp, min;
		for (int i = 0; i < length; i++)
		{
			min = i;
			temp = nums[i];
			for (int j = i + 1; j < length; j++)
			{
				if (nums[j] < nums[min])
				{
					min = j;
				}
			}
			nums[i] = nums[min];
			nums[min] = temp;
		}
		return nums;
	}
}



