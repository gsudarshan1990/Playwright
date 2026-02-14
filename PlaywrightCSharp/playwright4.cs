using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice
{
	public class playwright4 : IAsyncLifetime
	{
		private IPlaywright _playwright = null!;

		private IBrowser _browser =null!;

		private IPage _page = null!;
		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();

			_browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });

			_page = await _browser.NewPageAsync();

		}

		[Fact]

		public async Task LaunchWebsite()
		{
			await _page.GotoAsync("https://playwright.dev/");
			string title = await _page.TitleAsync();
			Assert.Contains("Playwright", title);
			await _page.GetByRole(AriaRole.Link, new() { Name ="Get Started"}).ClickAsync();
			string url = _page.Url;
			Assert.Contains("/docs", url);
			
		}

		public async Task DisposeAsync()
		{
			await _browser.DisposeAsync();
			_playwright.Dispose();
			
		}

		
	}
}
