using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace XunitBasics
{
	public class SingleTestForEachTestMethod
	{

		private readonly ITestOutputHelper _output;

		private int _myInt = 0;

		public SingleTestForEachTestMethod(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]

		public void Test1()
		{
			_myInt++;
			Assert.Equal(1, _myInt);
			_output.WriteLine("This is first Method");
		}

		[Fact]

		public void Test2()
		{
			_myInt++;
			Assert.Equal(1, _myInt);
			_output.WriteLine("This is Second Method");
		}
	}
}
