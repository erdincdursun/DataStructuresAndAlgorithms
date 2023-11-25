namespace Test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyArray array = new MyArray();
			array.Push("Busra");
			array.Push("Erdinc");
			array.Push("Ayse");
			array.Push("Omer");
			array.Push("Zeynep");

			//array.Pop();
			array.Delete(1);
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array.Get(i));
			}
			//Console.WriteLine(array.Get(1)); 


			ReverseString("ı'am erdinc");
			ReverseString2("ı'am erdinc");


			int[] array1 = { 1, 2, 8 };
			int length1 = array1.Length;
			int[] array2 = { 4, 5, 6 };
			int length2 = array2.Length;
			//result[] = {1,2,4,5,6,8}
			int[] array3 = new int[length1 + length2];

			MergeSortArray(array1, array2, array3, length1, length2);
			MergeSortArray2(array1, array2);



			for (int i = 0; i < array3.Length; i++)
			{
				Console.Write(array3[i]);
			}




		}
		#region ReverseString
		static void ReverseString(string s)
		{
			string newStrig = string.Empty;
			for (int i = s.Length - 1; i >= 0; i--)
			{
				newStrig += s[i];
			}
			Console.WriteLine(newStrig);
		}
		static void ReverseString2(string s)
		{
			char[] charArray = s.ToCharArray();
			Array.Reverse(charArray);
			string reversedString = new string(charArray);
			Console.WriteLine(reversedString);
		}
		#endregion

		public static void MergeSortArray(int[] arr1, int[] arr2, int[] arr3, int length1, int length2)
		{
			int i = 0, j = 0, k = 0;

			while (i < length1 && j < length2)
			{
				if (arr1[i] < arr2[j])
				{
					arr3[k++] = arr1[i++];
				}
				else
				{
					arr3[k++] = arr2[j++];
				}
			}
			while (i < length1)
				arr3[k++] = arr1[i++];

			while (j < length2)
				arr3[k++] = arr2[j++];
		}
		public static int[] MergeSortArray2(int[] arr1, int[] arry2)
		{
			int[] mergeSort = arr1.Concat(arry2).ToArray();
			Array.Sort(mergeSort);
			return mergeSort;
		}
	}
}

class MyArray
{
	public int Length;
	private Object[] Data;

	public MyArray()
	{
		this.Length = 0;
		this.Data = new Object[1];
	}

	public Object Get(int index)
	{
		return Data[index];
	}

	public Object[] Push(Object item)
	{
		if (this.Data.Length == this.Length)
		{
			Object[] temp = new Object[this.Length];
			Array.Copy(this.Data, temp, Length);
			this.Data = new Object[this.Length + 1];
			Array.Copy(temp, this.Data, Length);
		}

		this.Data[this.Length] = item;
		this.Length++;
		return this.Data;
	}

	public Object Pop()
	{
		Object poped = this.Data[this.Length - 1];
		this.Data[this.Length - 1] = null;
		Length--;
		return poped;
	}
	public Object Delete(int index)
	{
		Object delete = Data[index];
		ShiftItems(index);
		return delete;
	}
	private void ShiftItems(int index)
	{
		for (int i = index; i < this.Data.Length - 1; i++)
		{
			Data[i] = Data[i + 1];
		}
		Data[Length - 1] = null;
		Length--;
	}
}


