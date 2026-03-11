using System;
using System.Collections.Generic;
using System.Text;

namespace XunitBasics
{
	public  class ConfigurationFixture : IDisposable
	{
		public Dictionary<string, string> _appSettings { get; private set; }

		public ConfigurationFixture()
		{
			_appSettings = new Dictionary<string, string>
			{
				{"Theme","Dark"},
				{ "Maxusers","100"},
				{"TimeOutSeconds","30" },
				{"Framework","xunit" }

			};
		}
		public void Dispose()
		{
			_appSettings.Clear();
		}
	}
}
