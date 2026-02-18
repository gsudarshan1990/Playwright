using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using Playwright_Practice.pages;

namespace Playwright_Practice.Tests
{
	public class DynamicLoadingPageTest : IAsyncLifetime
	{
		private IPlaywright _playwright = null!;

		private BrowserTypeLaunchOptions _launchOptions = null!;

		private IBrowser _browser = null!;

		private IPage _page = null!;

		private readonly string url = "https://the-internet.herokuapp.com/dynamic_loading/1";

		private DynamicLoadingPage _dynamicLoadingPage = null!;

		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();

			_launchOptions = new BrowserTypeLaunchOptions { Headless = false };

			_browser = await _playwright.Chromium.LaunchAsync(_launchOptions);

			_page = await _browser.NewPageAsync();
		}

		[Fact]

		public async Task DynamicPageTest()
		{
			await _page.GotoAsync(url);
			await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
			_dynamicLoadingPage = new DynamicLoadingPage(_page);
			_dynamicLoadingPage.clickStartButton();
			await Expect(_dynamicLoadingPage.getHelloWorldLocator()).ToBeVisibleAsync(new() { Timeout = 10_000});
		}


		public async Task DisposeAsync()
		{
			await _browser.DisposeAsync();
			_playwright.Dispose();
		}
	}
}
