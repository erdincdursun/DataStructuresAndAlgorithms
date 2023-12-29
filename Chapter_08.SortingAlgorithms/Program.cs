namespace Chapter_08.SortingAlgorithms
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BubbleSort bubbleSort = new BubbleSort();
			SelectionSort selectionSort = new SelectionSort();
			InsertionSort insertionSort = new InsertionSort();
			int[] numbers = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4,0 };
			//bubbleSort.BubbleSortOne(numbers);
			//selectionSort.SelectionSortOne(numbers);
			//insertionSort.InsertionSortOne(numbers);
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.Write(numbers[i] + " ");
			//}

			MergeSort mergeSort = new MergeSort();
			//Merge Sort
			foreach (var item in mergeSort.MergeSortOne(numbers))
			{
				Console.Write(item + " ");
			}

		}
	}
}



