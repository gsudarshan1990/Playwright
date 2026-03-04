using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace XunitBasics
{
	public class SharedResource
	{
		public string data { get; }

		public SharedResource()
		{
		
			Console.WriteLine("Shared Resource Created");
			data = "Initialized Data";
		}
	}
}
