namespace Chapter_01.CustomArrayClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region MyArray
			//MyArray myArray = new MyArray();
			//myArray.Push("hello");
			//myArray.Push("busbus");
			//myArray.Push("erdinc");
			//myArray.Push("ayse");
			//myArray.Push("!");
			//myArray.Push("zeyno");
			//myArray.Push("ömer");
			//myArray.Push("mila");

			//myArray.Pop();

			//for (int i = 0; i < myArray.Length; i++)
			//{
			//	Console.WriteLine(myArray.Get(i));
			//}

			//myArray.Delete(4);
			#endregion
			#region ReverseString
			//ReverseAString text = new ReverseAString();
			//text.ReverseString("I'am Erdinc");
			//text.ReverseStringTwo("I'am Busra");
			#endregion
			#region MergeArray
			MergeSortedArrays mergeSortedArrays = new MergeSortedArrays();
			int[] arrayOne = { 0, 3, 4, 31 };
			int[] arrayTwo = {4,6,30};
			int[] arrayResult=(mergeSortedArrays.MergeSortedArray(arrayOne, arrayTwo));
            for (int i = 0; i < arrayResult.Length; i++)
            {
				Console.Write(arrayResult[i] + " ");
            }
			//arrayResult[0,3,4,4,6,30,31];


			int[] array1 = { 0, 3, 4, 31 };
			int size1 = array1.Length;
			
			int[] array2 = { 4,6,30};
			int size2 = array2.Length;

			int[] array3 = new int[size1 + size2];

			mergeSortedArrays.MergeArrays(array1 , array2, size1,size2, array3);


			Console.Write("Array after merging\n");
			for (int i = 0; i < size1 + size2; i++)
				Console.Write(array3[i] + " ");

			#endregion


		}
	}
}
