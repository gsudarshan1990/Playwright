using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice
{
	public class AirtelTest : IAsyncLifetime
	{
		private IPlaywright _playwright;

		private IBrowser _browser;

		private IPage _page;

		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();

			BrowserTypeLaunchOptions launchOptions = new BrowserTypeLaunchOptions { Headless = false };

			_browser = await _playwright.Chromium.LaunchAsync(launchOptions);

			_page = await _browser.NewPageAsync();
		}

		[Fact]

		public async Task LaunchAirtelWebsite()
		{
			await _page.GotoAsync("https://www.airtel.in/");
			await _page.WaitForLoadStateAsync();
			string title =await  _page.TitleAsync();
			Assert.Contains("Airtel", title);

			await _page.GetByRole(AriaRole.Link, new() { Name = "Service Quality" }).ClickAsync();
			await _page.WaitForLoadStateAsync();
			string url = _page.Url;
			Assert.Equal("https://www.airtel.in/service-quality/qos-performance?icid=footer", url);
		}

		public async Task DisposeAsync()
		{
				await _browser.DisposeAsync();
				_playwright.Dispose();
		}

	}
}
