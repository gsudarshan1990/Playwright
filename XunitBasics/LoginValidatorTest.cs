using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace XunitBasics
{
	public class LoginValidatorTest : IDisposable
	{
		private readonly ITestOutputHelper _output;

		private LoginValidator _loginValidator = null!;

		private LoginValidator _validator = null!;

		public LoginValidatorTest(ITestOutputHelper output)
		{
			_output = output;
			_loginValidator = new LoginValidator();
			_output.WriteLine("Testing the Login Password");
		}

		[Fact]

		public void Password_Minimium_Length_Check()
		{
			bool result = _loginValidator.passwordCheck("Ramesh08");
			Assert.True(result);
			_output.WriteLine("Password is validated successfully");
		}

		[Theory]
		[InlineData("Rakesh08",true)]
		[InlineData("Rakesh0",false)]
		[InlineData("",false)]
		[InlineData("suresh89",true)]
		public void Password_Minimum_Length_Check_Input_Output(string input, bool expected)
		{
			//Arrange 
			_validator = new LoginValidator();

			//Act
			bool result = _validator.passwordCheck(input);

			_output.WriteLine($"Password : {input} | Expected : {expected} | Result : {result} ");

			//Assert

			Assert.Equal(expected, result);

		}


		public void Dispose()
		{
			_output.WriteLine("Test is Disposed");
		}
	}
}
