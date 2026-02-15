using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.Playwright;
using System.Xml.Serialization;
using Playwright_Practice.pages;



namespace Playwright_Practice.Tests
{
	public class LoginTest : IAsyncLifetime
	{
		private IPlaywright _playwright;

		private IBrowser _browser;

		private BrowserTypeLaunchOptions _launchOptions;

		private IPage _page;

		private LoginPage _loginpage;

		private string _username;

		private string _password;

		private string url;

		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();

			_launchOptions = new BrowserTypeLaunchOptions { Headless = false };

			_browser = await _playwright.Chromium.LaunchAsync(_launchOptions);

			_page = await _browser.NewPageAsync();

			_loginpage = new LoginPage(_page);

			_username = "standard_user";

			_password = "secret_sauce";

		}

		[Fact]
		public async Task SauceDemoLoginTest()
		{
			await _page.GotoAsync("https://www.saucedemo.com/");
			await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
			await _loginpage.LoginToPage(_username, _password);
			await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
			url = _page.Url;
			Assert.Equal("https://www.saucedemo.com/inventory.html", url);
		}

		public async Task DisposeAsync()
		{
			_browser.DisposeAsync();
			_playwright.Dispose();

		}
		
	}
}
