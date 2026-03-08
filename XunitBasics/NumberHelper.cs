using System;
using System.Collections.Generic;
using System.Text;

namespace XunitBasics
{
	public class NumberHelper
	{

		public bool isOdd(int number)
		{
			return number % 2 == 1;
		}

		public bool isEven(int number)
		{
			return number % 2 == 0;
		}
	}
}
