using System;
using System.Collections.Generic;
using System.Text;

namespace XunitBasics
{
	public class TestHelperTest
	{
		TestHelper th = new TestHelper();

		[Fact]

		public void CountWords_HelloWorld_ReturnsTwo()
		{
			Assert.Equal(2,th.CountWords("Hello World"));
		}

		[Theory]
		[InlineData("Hello World", 2)]
		[InlineData("Hello World from Xunit", 4)]
		[InlineData("",0)]
		[InlineData(" ",0)]
		public void CountWords_ReturnsExpected(string input, int expected)
		{
			Assert.Equal(expected, th.CountWords(input));
		}

		[Theory]
		[InlineData("hello","HELLO")]
		[InlineData("hello world","HELLO WORLD")]
		[InlineData("","")]
		[InlineData(null,"")]
		[InlineData("123","123")]

		public void ReturnsUpper_input_output(string? input, string? expected)
		{
			Assert.Equal(expected, th.ConvertToUpper(input! ));
		}
	}
}
