using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XunitBasics
{
	public class ConsoleRunTest
	{
		[Fact]
		public void simple_test()
		{
			Console.WriteLine("This is a sample test");
			Assert.True(true);
		}

		[Fact]

		public void simple_test2()
		{
			Console.WriteLine("This test ran from the console");
			
		}
	}
}
