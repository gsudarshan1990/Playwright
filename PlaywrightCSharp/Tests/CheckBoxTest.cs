using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using Playwright_Practice.pages;
using static Microsoft.Playwright.Assertions;

namespace Playwright_Practice.Tests
{
	public class CheckBoxTest : IAsyncLifetime
	{
		private IPlaywright _playwright = null!;

		private BrowserTypeLaunchOptions _launchOption = null!;

		private IBrowser _browser = null;

		private IPage _page = null!;

		private string url = "https://the-internet.herokuapp.com/checkboxes";

		private CheckBoxPage _checkBoxPage = null!;

		private ILocator _checkBox1 = null!;

		private ILocator _checkBox2 = null!;



		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();

			_launchOption = new BrowserTypeLaunchOptions { Headless = false };

			_browser = await _playwright.Chromium.LaunchAsync(_launchOption);

			_page = await _browser.NewPageAsync();
		}


		[Fact]

		public async Task CheckBoxCheckingTest()
		{
			await _page.GotoAsync(url);
			_checkBoxPage = new CheckBoxPage(_page);
			_checkBox1 = _checkBoxPage.getCheckBox1();
			_checkBox2 = _checkBoxPage.getCheckBox2();
			await Expect(_checkBox1).Not.ToBeCheckedAsync();
			await Expect(_checkBox2).ToBeCheckedAsync();
			await _checkBox1.CheckAsync();
			await _checkBox2.UncheckAsync();
			await Expect(_checkBox1).ToBeCheckedAsync();
			await Expect(_checkBox2).Not.ToBeCheckedAsync();



		}
		public async Task DisposeAsync()
		{
			await _browser.DisposeAsync();
			_playwright.Dispose();
		}


		
	}
}
