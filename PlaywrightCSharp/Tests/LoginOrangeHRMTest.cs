using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using Playwright_Practice.pages;

namespace Playwright_Practice.Tests
{
	public class LoginOrangeHRMTest : IAsyncLifetime
	{
		private IPlaywright _playwright = null!;

		private IBrowser _browser = null!;

		private BrowserTypeLaunchOptions _launchOptions = null!;

		private IPage _page = null!;

		private LoginOrangeHRMPage _loginOrangeHrmpage = null!;

		private PageGotoOptions _gotoOptions = null;

		

		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();

			_launchOptions = new BrowserTypeLaunchOptions { Headless = false };

			_browser = await _playwright.Chromium.LaunchAsync(_launchOptions);

			_page = await _browser.NewPageAsync();

			_gotoOptions = new PageGotoOptions
			{
				WaitUntil = WaitUntilState.DOMContentLoaded
			};

		}

		[Fact]

		public async Task LoginToOrangeHRMWebsite()
		{
			await _page.GotoAsync("https://opensource-demo.orangehrmlive.com/", _gotoOptions);

			_loginOrangeHrmpage = new LoginOrangeHRMPage(_page);

			_loginOrangeHrmpage.LoginToOrangeHRMPortal("Admin", "admin123");

			await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
		}


		public async Task DisposeAsync()
		{
			await _browser.DisposeAsync();
			_playwright.Dispose();
		}
	}
}
