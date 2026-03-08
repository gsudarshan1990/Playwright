using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Serialization;
using Xunit;


namespace XunitBasics
{
	public class PasswordValidatorTest
	{
		[Fact(Skip = "To practice skip")]
		//Positive Test case1
		public void ValidatityTest1()
		{
			//Arrange
			PasswordValidator _validator = new PasswordValidator();
			const string password = "Th1sIsapassword!";

			//Act
			bool result = _validator.IsValid(password);

			//Assert

			Assert.True(result, $"This password {password} is not valid");


		}

		[Fact]
		[Trait("password","validpassword")]
		public void ValidityTest2()
		{
			//Arrange
			PasswordValidator _validator = new PasswordValidator();
			const string password = "testPassword@123";

			//Act
			bool result = _validator.IsValid(password);

			//Assert

			Assert.True(result, $"The password {password} is not valid");

			//The above assert will print the string sentence only the Assert.True will fail

		}


		[Fact]
		//NegativeTestCase
		[Trait("password", "inValidpassword")]
		public void ValidityTest3()
		{
			//Arrange
			PasswordValidator _validator = new PasswordValidator();
			const string password = "thisIsaPassword";

			//Act

			bool result = _validator.IsValid(password);

			Assert.False(result, $"This password {password} should not be valid");
		}


		[Theory]
		[InlineData("Th1sIsapassword!", true)]
		[InlineData("thisIsapassword123!", true)]
		[InlineData("", false)]
		[InlineData("thisIsaPassword", false)]

		public void ValidityTest4(string password, bool expected)
		{
			//Arrange
			PasswordValidator _validator = new PasswordValidator();

			bool result = _validator.IsValid(password);

			Assert.Equal(expected, result);

		}

		public static IEnumerable<object[]> passwordData =>
			new List<object[]>
			{
				new object[] {"Th1sIsapassword!",true},
				new object[] { "thisIsapassword123!",true },
				new object[] { "thisIsaPassword",false },
				new object[] {"",false}

			};

		[Theory]
		[MemberData(nameof(passwordData))]

		[Trait("password", "validpassword")]

		public void _validityTest(string password, bool expected)
		{
			//Arrange
			PasswordValidator _validator = new PasswordValidator();

			//Act

			bool result = _validator.IsValid(password);

			//Assert

			Assert.Equal(expected, result);


		}
	}
}
