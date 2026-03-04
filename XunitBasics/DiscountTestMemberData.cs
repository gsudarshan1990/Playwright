using System;
using System.Collections.Generic;
using System.Text;

namespace XunitBasics
{
	public class DiscountTestMemberData
	{
		public static IEnumerable<object[]> testData =>
			new List<object[]>
			{
				new object[] {1000, 10, 900},
				new object[] {800, 20,640},
				new object[] {5000, 50, 2500}
			};

		[Theory]
		[MemberData(nameof(testData))]

		public void DiscountTest(int price, int discount, int expected)
		{
			var result = price - (price * discount) / 100;
			Assert.Equal(expected, result);

		}

        

	}
}
