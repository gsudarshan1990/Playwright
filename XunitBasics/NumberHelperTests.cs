using System;
using System.Collections.Generic;
using System.Text;

namespace XunitBasics
{
	public class NumberHelperTests
	{
		public static IEnumerable<object[]> oddNumber =>
			new List<object[]>
			{

				new object[] {3,true},
				new object[] {9,true},
				new object[] {13,true},
				new object[] {6,false}
			};

		public static IEnumerable<object[]> evenNumber =>
			new List<object[]>
			{
				new object[] {4,true},
				new object[] {6,true},
				new object[] {8,true},
				new object[] {7,false},
			};

		[Theory]
		[MemberData(nameof(oddNumber))]

		public void oddTest(int number, bool expected)// Using Member Data
		{
			//Arrange 
			NumberHelper nh = new NumberHelper();

			//Act

			bool result = nh.isOdd(number);

			//Assert

			Assert.Equal(expected, result);
		}

		[Theory]
		[MemberData(nameof(evenNumber))]

		public void evenTest(int number, bool expected)// Using Member Data
		{
			//Arrange
			NumberHelper nh = new NumberHelper();

			//Act
			bool result = nh.isEven(number);

			//Assert
			Assert.Equal(expected, result);



		}



	}
}
