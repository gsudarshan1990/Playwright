using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace XunitBasics
{
	public class PasswordLengthValidTest
	{
		private readonly ITestOutputHelper _output;

		public PasswordLengthValidTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Theory]
		[ClassData(typeof(PasswordTestData))]

		public void testPassword(string password, bool expected)
		{
			_output.WriteLine($" Password : {password} | Expected : {expected}");
			Assert.Equal(expected,password.Length > 8);
		}
	}
}
