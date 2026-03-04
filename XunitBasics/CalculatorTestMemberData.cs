using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XunitBasics
{
	public class CalculatorTestMemberData
	{
		Calculator calc1 = new Calculator();
		public static IEnumerable<Object[]> TestData =>
			new List<object[]>
			{
				new object[] {2, 4, 6},
				new object[] {12,22,34},
				new object[] {34,22,56}

			};

		[Theory]
		[MemberData(nameof(TestData))]
		public void Add_Numbers_Input1_Input2_ReturnsExpected(int a,int b, int expected)
		{
			Assert.Equal(expected, calc1.Add(a, b));
		}
	}
}
