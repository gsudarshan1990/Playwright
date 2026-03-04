using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XunitBasics
{
	public class StringValidMemberData
	{
		public static IEnumerable<Object[]> stringData =>
			new List<Object[]>
			{
				new object[]{"Rakesh",true},
				new object[] {"",false},
				new object[] {"Playwright",true},
				new object[] {null!,false}

			};

		[Theory]
		[MemberData(nameof(stringData))]

		public void TestStringRepresentation(string input, bool expected)
		{
			var result = !(string.IsNullOrEmpty(input));
			Assert.Equal(expected, result);
		}

	}
}
