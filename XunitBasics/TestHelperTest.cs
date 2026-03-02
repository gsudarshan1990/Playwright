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

		[Fact]
		[Trait("Category", "string")]

		public void TestApplicationSummary()
		{
			Assert.Equal("Country : India | Currency : INR | Environment : Production", th.GetApplicationConfigurationSummary());
		}

		[Theory]
		[Trait("Category","string")]
		[InlineData("Hello World", 2)]
		[InlineData("Hello World from Xunit", 4)]
		[InlineData("",0)]
		[InlineData(null,0)]
		
		public void CountWords_ReturnsExpected(string? input, int expected)
		{
			Assert.Equal(expected, th.CountWords(input!));
		}

		[Theory]
		[Trait("Category", "string")]
		[InlineData("hello","HELLO")]
		[InlineData("hello world","HELLO WORLD")]
		[InlineData("","")]
		[InlineData(null,"")]
		[InlineData("123","123")]

		public void ReturnsUpper_input_output(string? input, string? expected)
		{
			Assert.Equal(expected, th.ConvertToUpper(input! ));
		}


		[Theory]
		[Trait("Category", "math")]
		[InlineData(2)]
		[InlineData(4)]
		[InlineData(0)]
		[InlineData(8)]
		[InlineData(-2)]

		public void ChecksEvenorNot_input_output(int input)
		{
			Assert.True(th.IsEven(input));
		}


		[Theory]
		[Trait("Category", "math")]
		[InlineData(2, true)]
		[InlineData(4,true)]
		[InlineData(3,false)]
		public void ChecksEvenorNot_inputoutput(int input, bool expected)
		{
			Assert.Equal(expected, th.IsEven(input));
		}


		[Theory]
		[Trait("Category","string")]
		[InlineData(new string[] {"India","INR","PRODUCTION"}, "Country : India | Currency : INR | Environment : PRODUCTION")]
		[InlineData(new string[] { "Britain", "POUND", "DEVELOPMENT" }, "Country : Britain | Currency : POUND | Environment : DEVELOPMENT")]
		[InlineData(new string[] { "USA", "DOLLAR", "UAT" }, "Country : USA | Currency : DOLLAR | Environment : UAT")]
		[InlineData(new string[] { "JAPAN", "YEN", "SIT" }, "Country : JAPAN | Currency : YEN | Environment : SIT")]

		public void checkApplicationConfiguration_input_output(string[] input, string expected)
		{
			Assert.Equal(expected,th.GetApplicationConfigurationSummaryForMultipleData(input));
		}
	}
}
