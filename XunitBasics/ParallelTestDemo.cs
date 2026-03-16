using System;
using System.Collections.Generic;
using System.Text;

namespace XunitBasics
{
	public class ParallelTestDemo
	{

		
	}

	[Collection("collection 1")]
	public class TestClass1
	{
		[Fact]

		public void Test1()
		{
			Thread.Sleep(3000);
		}

	}

	[Collection("collection 1")]
	public class TestClass2
	{
		[Fact]
		public void Test2()
		{
			Thread.Sleep(5000);
		}

	}

}
