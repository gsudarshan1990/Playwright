using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace XunitBasics
{
	public class PrintTestResultsTests
	{
		private readonly ITestOutputHelper _output;

		public PrintTestResultsTests(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]

		public async Task SampleOutputPrint()
		{
			_output.WriteLine("This is a sample output test");
			_output.WriteLine("Not using the Console to print");
		}
	}
}
