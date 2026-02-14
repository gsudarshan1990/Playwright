using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using Xunit;

namespace Playwright_Practice 
{
	public class playwrightpagetest : IAsyncLifetime
	{
		private IPlaywright _playwright;

		private IBrowser _browser;

		private IPage _page;

		private BrowserTypeLaunchOptions _launchOptions;
		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();

			_launchOptions = new BrowserTypeLaunchOptions{ Headless = false};

			_browser = await _playwright.Chromium.LaunchAsync(_launchOptions) ;

			_page = await _browser.NewPageAsync();

		}

		[Fact]

		public async Task PlaywrightIntroPageTest()
		{
			await _page.GotoAsync("https://playwright.dev/");
						
			await _page.GetByRole(AriaRole.Link, new() { Name = "Get Started" }).ClickAsync();
						
			var header =  _page.GetByRole(AriaRole.Heading, new() { Name = "Installation" });

			await header.WaitForAsync(new LocatorWaitForOptions { State = WaitForSelectorState.Visible });

			Assert.True(await header.IsVisibleAsync());

			await _page.GetByRole(AriaRole.Link, new() { Name = "Getting started - VS Code" }).ClickAsync();

			await _page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);

			string url = _page.Url;

			Assert.Equal("https://playwright.dev/docs/getting-started-vscode", url);

		}

		public async Task DisposeAsync()
		{
			await _browser.DisposeAsync();
			_playwright.Dispose();
		}
	}
}
