using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using Playwright_Practice.pages;

namespace Playwright_Practice.Tests
{
	public class AdminDemoTestPage : IAsyncLifetime
	{
		private  IPlaywright _playwright = null!;

		private  BrowserTypeLaunchOptions _launchOption = null!;

		private  IBrowser _browser = null!;

		private IPage _page = null!;

		private AdminDemo _adminDemo = null!;

		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();

			_launchOption = new BrowserTypeLaunchOptions { Headless = false };

			_browser = await _playwright.Chromium.LaunchAsync(_launchOption);

			_page = await _browser.NewPageAsync();

		}

		[Fact]

		public async Task LoginAdminDemon()
		{
			
			await _page.GotoAsync("https://admin-demo.nopcommerce.com/");

			await Task.Delay(2000);

			_adminDemo = new AdminDemo(_page);

			await _adminDemo.clickSignuplogin("admin@yourstore.com", "admin");

			await _page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);



		}



		public async Task DisposeAsync()
		{
			await _browser.DisposeAsync();
			_playwright.Dispose();
		}
	}
}
