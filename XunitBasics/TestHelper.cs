using System;
using System.Collections.Generic;
using System.Text;

namespace XunitBasics
{
	public class TestHelper
	{
		public int CountWords(string input)
		{
			if(string.IsNullOrWhiteSpace(input))
			{
				return 0;
			}
			string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			return words.Length;
		}

		public string ConvertToUpper(string input)
		{
			if (input == null)
			{
				return "";
			}
			return input.ToUpper();

		}
	}
}
