using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using Playwright_Practice.pages;
using static Microsoft.Playwright.Assertions;

namespace Playwright_Practice.Tests
{
	public class AutomationExerciseTest : IAsyncLifetime
	{
		private IPlaywright _playwright = null!;

		private BrowserTypeLaunchOptions _launchOptions = null!;

		private IBrowser _browser = null!;

		private IPage _page = null!;

		private string url = "https://automationexercise.com/";

		private AutomationExercisePage _automationExercisePage = null!;

		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();

			_launchOptions = new BrowserTypeLaunchOptions { Headless = false };

			_browser = await _playwright.Chromium.LaunchAsync(_launchOptions);

			_page = await _browser.NewPageAsync();
		}

		[Fact]

		public async Task TestHomePageNavigation()
		{
			await _page.GotoAsync(url);
			_automationExercisePage = new AutomationExercisePage(_page);
			await Expect(_automationExercisePage.returnImage()).ToBeVisibleAsync();
			await Expect(_automationExercisePage.returnFeatureItems()).ToHaveTextAsync("Features Items");
			await _automationExercisePage.clickWomen();
			await Expect(_automationExercisePage.returnDress()).ToBeVisibleAsync();
			await Expect(_automationExercisePage.returnTops()).ToBeVisibleAsync();
			await Expect(_automationExercisePage.returnSaree()).ToBeVisibleAsync();
		}

		public async Task DisposeAsync()
		{

		}


	}

}
