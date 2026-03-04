using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XunitBasics
{
	public class ValidNumberMemberData
	{
		public static IEnumerable<object[]> NumberData =>
			new List<object[]>
			{
				new object [] {1,true},
				new object [] {100, true},
				new object [] {0,false},
				new object [] {101,false},
				new object [] {-30,false},
				new object [] {25,true}

			};


		[Theory]
		[MemberData(nameof(NumberData))]

		public void ValidNumber(int value, bool expected )
		{
			var result = value > 0 && value <= 100;
			Assert.Equal(expected, result);
		}

       // Provide another member data and another test method

        public static IEnumerable<object[]> StringData =>
            new List<object[]>
            {
                new object [] {"Hello", true},
                new object [] {"", false},
                new object [] {null, false},
                new object [] {"Xunit", true}
            };

        [Theory]
        [MemberData(nameof(StringData))]
        public void ValidString(string input, bool expected)
        {
            var result = !string.IsNullOrEmpty(input);
            Assert.Equal(expected, result);
        }



	}
}
