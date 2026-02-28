using System;
using System.Collections.Generic;
using System.Text;

namespace XunitBasics
{
	public class CalculatorTest
	{
		public Calculator calc = new Calculator();

		[Theory]
		[InlineData(1,3,4)]
		[InlineData(8, 5, 13)]
		[InlineData(12, 5, 17)]

		public void CalculateAdd_input_output(int a, int b, int c)
		{
			Assert.Equal(c, calc.Add(a, b));
		}

		[Theory]
		[InlineData(1, 3, -2)]
		[InlineData(8, 5, 3)]
		[InlineData(12, 5, 7)]

		public void CalculateSubtract_input_output(int a, int b, int c)
		{
			Assert.Equal(c, calc.subtract(a, b));
		}


		[Theory]
		[InlineData(1, 3, 3)]
		[InlineData(8, 5, 40)]
		[InlineData(12, 5, 60)]

		public void CalculateMultiply_input_output(int a, int b, int c)
		{
			Assert.Equal(c, calc.multiply(a, b));
		}

		[Theory]
		[InlineData(10, 2, 5)]
		[InlineData(8, 0, 8)]
		[InlineData(60, 6, 10)]

		public void CalculateDivide_input_output(int a, int b, int c)
		{
			Assert.Equal(c, calc.divide(a, b));
		}
	}
}
