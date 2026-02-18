using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using Playwright_Practice.pages;
using static Microsoft.Playwright.Assertions;

namespace Playwright_Practice.Tests
{
	public class ShapeLiftingButtonChallengeTest : IAsyncLifetime
	{
		private IPlaywright _playwright = null!;

		private BrowserTypeLaunchOptions _launchOptions = null!;

		private IBrowser _browser = null!;

		private IPage _page = null!;

		private string url = "http://uitestingplayground.com/textinput";

		private string _textToEnter = "Iron Man";

		private ShapeLiftingButtonChallengePage _buttonChallenge = null!;
		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();

			_launchOptions = new BrowserTypeLaunchOptions { Headless = false };

			_browser = await _playwright.Chromium.LaunchAsync(_launchOptions);

			_page = await _browser.NewPageAsync();

		}

		[Fact]

		public async Task DynamicButtonChallenge()
		{
			await _page.GotoAsync(url);
			await _page.WaitForLoadStateAsync(LoadState.Load);
			_buttonChallenge = new ShapeLiftingButtonChallengePage(_page);
			_buttonChallenge.EnterTextData(_textToEnter);
			_buttonChallenge.clickButton();
			await Expect(_buttonChallenge.returnButtonLocator()).ToHaveTextAsync(_textToEnter);

		}

		public async Task DisposeAsync()
		{
			await _browser.DisposeAsync();
			_playwright.Dispose();

		}
	}
}
