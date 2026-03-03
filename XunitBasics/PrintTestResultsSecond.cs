using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace XunitBasics
{
	public class PrintTestResultsSecond : IDisposable
	{
		private readonly ITestOutputHelper _output;
		public PrintTestResultsSecond(ITestOutputHelper output)
		{
			this._output = output;
			_output.WriteLine("Constructor is called");
		}

		[Fact]

		public void Sampletest1()
		{
			_output.WriteLine("First test is called");
			Assert.True(true);
		}

		[Fact]

		public void Sampletest2()
		{
			_output.WriteLine("This is second test");
			_output.WriteLine("Using the Dependency Injection to print on the test explorer");
		}

		public void Dispose()
		{
			_output.WriteLine("Dispose is called");
		}
	}
}
