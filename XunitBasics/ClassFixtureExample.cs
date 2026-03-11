using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XunitBasics
{
	public class ClassFixtureExample : IClassFixture<ConfigurationFixture>
	{
		private readonly ConfigurationFixture _fixture;

		public ClassFixtureExample(ConfigurationFixture fixture	)
		{
			_fixture = fixture;
		}

		[Fact]

		public async Task test1()
		{
			bool result = _fixture._appSettings.ContainsKey("Theme");
			Assert.True(result);
		}

		[Fact]

		public async Task test2()
		{
			bool result = _fixture._appSettings.ContainsKey("Framework");
			Assert.True(result);
		}

		[Fact]

		public async Task test3()
		{
			bool result = _fixture._appSettings.ContainsKey("abcd");
			Assert.False(result);
		}
	}
}
