using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using Playwright_Practice.pages;
using static Microsoft.Playwright.Assertions;

namespace Playwright_Practice.Tests
{
	public class DynamicControlsTest : IAsyncLifetime
	{
		private IPlaywright _playwright = null!;

		private BrowserTypeLaunchOptions _launchOptions = null!;

		private IBrowser _browser = null!;

		private IPage _page = null!;

		private DynamicControlsPage _dynamicControlPage = null!;

		private readonly string url = "https://the-internet.herokuapp.com/dynamic_controls";

		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();

			_launchOptions = new BrowserTypeLaunchOptions { Headless = false };

			_browser = await _playwright.Chromium.LaunchAsync(_launchOptions);

			_page = await _browser.NewPageAsync();


		}

		[Fact]

		public async Task DynamicControlsTesting()
		{
			await _page.GotoAsync(url);
			await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
			_dynamicControlPage = new DynamicControlsPage(_page);
			await Expect(_dynamicControlPage.getCheckBox()).ToBeVisibleAsync();
			_dynamicControlPage.clickRemoveButton();
			await Expect(_dynamicControlPage.getCheckBox()).ToBeHiddenAsync();
			await Expect(_dynamicControlPage.getItsGone()).ToBeVisibleAsync();
			await Expect(_dynamicControlPage.getItsGone()).ToHaveTextAsync("It's gone!");


		}

		public async Task DisposeAsync()
		{
			await _browser.DisposeAsync();
			_playwright.Dispose();

		}
	}
}
