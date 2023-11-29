using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_01.CustomArrayClass
{
	public class ReverseAString
	{
	
		public void ReverseString(string text)
		{
			string newText = string.Empty;
			for (int i = text.Length-1; i >= 0; i--)
            {
				newText += text[i];
            }
            Console.Write(newText);
        }
		public void ReverseStringTwo(string text)
		{
			char[] charArray = text.ToCharArray();
			Array.Reverse(charArray);
			string reversedString = new string(charArray);
            Console.WriteLine(reversedString);	
        }
	}
}

