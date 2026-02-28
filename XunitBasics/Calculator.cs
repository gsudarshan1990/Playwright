using System;
using System.Collections.Generic;
using System.Text;

namespace XunitBasics
{
	public class Calculator
	{

		public int Add(int a, int b)
		{
			return a + b;
		}

		public int subtract(int a, int b)
		{
			return a - b;
		}

		public int multiply(int a, int b)
		{
			return a * b;
		}

		public int divide(int a, int b)
		{
			if (b == 0)
			{
				b = 1;
			}

			return (a / b);
		}
	}
}
