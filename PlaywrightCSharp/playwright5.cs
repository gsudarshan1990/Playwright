using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice
{
	public class playwright5 : IAsyncLifetime
	{

		private IPlaywright _playwright;
		private IBrowser _browser;
		private IPage _page;
		
		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();
			_browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
			_page = await _browser.NewPageAsync();
		}

		[Fact]

		public async Task LaunchCourseWebsite()
		{
			await _page.GotoAsync("https://www.coursera.org/");
			string title = await _page.TitleAsync();
			Assert.Contains("Coursera", title);
			await _page.WaitForLoadStateAsync();
			await _page.GetByRole(AriaRole.Button, new() { Name ="Log In"}).ClickAsync();
			string url = _page.Url;
			Assert.Equal("https://www.coursera.org/?authMode=login", url);

		}
		public async Task DisposeAsync()
		{
			await _browser.DisposeAsync();
			_playwright.Dispose();
		}

	}
}
