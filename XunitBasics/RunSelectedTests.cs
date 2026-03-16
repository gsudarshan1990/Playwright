using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xunit.Abstractions;

namespace XunitBasics
{
	public class RunSelectedTests
	{
		public ITestOutputHelper _output;

		public RunSelectedTests(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact, Trait("priority", "1"), Trait("Category","CategoryA")]

		public void Test1()
		{
			_output.WriteLine("This is the first test");
		}

		[Fact, Trait("priority","2")]
		public void Test2()
		{
			_output.WriteLine("This is the second test");
		}

	}

}

// dotnet test --filter FullyQualifiedName~RunSelectedTests.Test1
// dotnet test --filter FullyQualifiedName~RunSelectedTests.Test2
// dotnet test --filter "priority=1"
// dotnet test --filter "Category=CategoryA"
// dotnet test --filter "priority=1&Category=CategoryA"
// dotnet test --filter "priority=1|Category=CategoryA"
