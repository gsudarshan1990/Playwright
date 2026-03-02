using System;
using System.Collections.Generic;
using System.Text;

namespace XunitBasics
{
	public class TestHelper
	{
		string country = "India";

		string currency = "INR";

		string environment = "Production";
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

		public bool IsEven(int number) { return number % 2 == 0; }

		public string GetApplicationConfigurationSummary()
		{
			return $"Country : {country} | Currency : {currency} | Environment : {environment}";
		}


		public string GetApplicationConfigurationSummaryForMultipleData(string[] input)
		{
			return $"Country : {input[0]} | Currency : {input[1]} | Environment : {input[2]}";
		}
		

	}
}
