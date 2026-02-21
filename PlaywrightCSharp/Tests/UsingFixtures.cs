using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using static System.Net.WebRequestMethods;

namespace Playwright_Practice.Tests
{
	public class UsingFixtures : IClassFixture<PlaywrightFixture>
	{
		private readonly IBrowser _browser = null!;

		private IPage _page = null!;

		string url = "https://example.com";

		public UsingFixtures(PlaywrightFixture fixture)
		{
			_browser = fixture._browser;
		}

		[Fact]

		public async Task NavigateToExamplePage()
		{
			var _context = await _browser.NewContextAsync();
			_page = await _context.NewPageAsync();
			await _page.GotoAsync(url);
			await Task.Delay(3000);
			await _context.CloseAsync();
		}

	}
}
