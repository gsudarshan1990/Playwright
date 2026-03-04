using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XunitBasics
{
	public class LoginTestsCategorization
	{
		[Fact]
		[Trait("Category","Smoke")]

		public void Login_Test_valid()
		{
			Assert.True(true);
		}

		[Fact]
		[Trait("Category","Regression")]

		public void Login_Test_Invalid()
		{
			Assert.True(true);
		}

		[Fact]
		[Trait("Category","UI")]
		[Trait("Priority","1")]
		

		public void UITest()
		{
			Assert.True(true);
		}
	}
}
