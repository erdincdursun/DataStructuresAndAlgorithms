using System.Collections;

namespace Exercise
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region FirstRecurringCharacter

			//Google Question
			//Given an array = [2,5,1,2,3,5,1,2,4]:
			//It should return 2

			//Given an array = [2,1,1,2,3,5,1,2,4]:
			//It should return 1

			//Given an array = [2,3,4,5]:
			//It should return undefined

			int[] array = { 2, 5, 1, 2, 3, 5, 1, 2, 4 };

            Console.WriteLine(FirstRecurringCharacter(array)); 

			#endregion
		}
		public static int FirstRecurringCharacter(int[] array)
		{
			Hashtable hashtable = new Hashtable();

			for (int i = 0; i < array.Length; i++)
			{
				if (hashtable.ContainsKey(array[i]))
				{
					return array[i];
				}
				hashtable[array[i]] = array[i];
			}
			return 0;

		}
	}
}
