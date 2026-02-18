using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using System.Xml.Serialization;
using Playwright_Practice.pages;
using System.Net.Http.Headers;
using System.Diagnostics.CodeAnalysis;



namespace Playwright_Practice.Tests
{
	public class LoginTest : IAsyncLifetime
	{
		private IPlaywright _playwright = null!;

		private IBrowser _browser = null!;

		private BrowserTypeLaunchOptions _launchOptions = null!;

		private IPage _page = null!;

		private LoginPage _loginpage = null!;

		private InventorySwagLabs _inventorySwagLabs = null!;

		private string _username = null!;

		private string _password = null!;

		private string url = null!;

		private string _cartBadgeValue = null!;

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
			_inventorySwagLabs = new InventorySwagLabs(_page);
			_inventorySwagLabs.clickAddToCartSaucelabsBackPack();
			await Task.Delay(2000);
			_cartBadgeValue = await _inventorySwagLabs.getCartBadgeValue();
			Assert.Equal("1", _cartBadgeValue);
			await Expect(_inventorySwagLabs.getRemoveButton()).ToHaveTextAsync("Remove");

		}

		public async Task DisposeAsync()
		{
			await _browser.DisposeAsync();
			_playwright.Dispose();

		}
		
	}
}
