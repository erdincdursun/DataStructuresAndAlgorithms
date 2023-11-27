namespace Test2
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine(ReverseString("I'am Erdinc"));
		ReverseString2("karım");


		}
		static string ReverseString(string s)
		{
			string newString = String.Empty;
            for (int i = s.Length-1; i >=0; i--)
            {
				newString += s[i];
            }
			return newString;
        }

		public static void ReverseString2(string st)
		{
			char[] newString = st.ToCharArray();
			Array.Reverse(newString);
			string reversedString = new string(newString);
			Console.WriteLine(reversedString);

		}

	}


}


