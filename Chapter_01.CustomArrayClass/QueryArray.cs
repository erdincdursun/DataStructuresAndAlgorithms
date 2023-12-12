using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_01.CustomArrayClass
{
	public class QueryArray<T>
	{
		private T[] arr;
		private int arrSize;
		private const int defaultCapacity = 1_000;
		private int currentIndex;
		private bool endOfFile;
		private bool beginningOfFile;

		public QueryArray(int capacity)
		{
			arr = new T[capacity];
			arrSize = capacity;
			Reset();
		}
		public QueryArray() : this(defaultCapacity)
		{

		}
		public T Current => arr[currentIndex];

		public void Reset()
		{
			SetIndex(-1);
		}
		private void SetCurrent(int increase)
		{
			SetIndex(currentIndex + increase);
			endOfFile = currentIndex >= arrSize - 1;
			beginningOfFile = currentIndex == 0;
		}
		private void SetIndex(int index)
		{
			currentIndex = index;
		}
		public bool Next()
		{
			if (!endOfFile)
			{
				SetCurrent(1);
				return true;
			}
			return false;
		}
		public bool Previous()
		{
			if (!beginningOfFile)
			{
				SetCurrent(-1);
				return true;
			}
			return false;
		}
		public void LoadFromArray(T[] newArr)
		{
			Load(newArr);
		}
		private void Load(T[] newArr)
		{
			ArgumentNullException.ThrowIfNull(newArr);
			arr = newArr;
			arrSize = newArr.Length;
			Reset();
		}
		public static implicit operator QueryArray<T>(T[] newArray)
		{
			var query = new QueryArray<T>();
			query.LoadFromArray(newArray);
			return query;
		}
	}
}
