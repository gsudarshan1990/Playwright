using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Microsoft.Playwright;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Playwright_Practice.pages;
using static Microsoft.Playwright.Assertions;

namespace Playwright_Practice.Tests
{
	public class TheTimeOutExplanationTest : IAsyncLifetime
	{
		private IPlaywright _playwright = null!;

		private BrowserTypeLaunchOptions _launchOptions = null!;

		private IBrowser _browser = null!;

		private IPage _page = null!;

		private string url = "http://uitestingplayground.com/ajax";

		private TheTimeOutExplanationPage _timeoutExplanation = null!;

		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();
			_launchOptions = new BrowserTypeLaunchOptions { Headless = false };
			_browser = await _playwright.Chromium.LaunchAsync(_launchOptions);
			_page = await _browser.NewPageAsync();
			
		}

		[Fact]

		public async Task TimeOutUtilization()
		{
			await _page.GotoAsync(url);
			_timeoutExplanation = new TheTimeOutExplanationPage(_page);
			_timeoutExplanation.ClickButton();
			await Expect(_timeoutExplanation.ReturnDataLocator()).ToHaveTextAsync("Data loaded with AJAX get request.", new () { Timeout = 20_000});
			

		}
		public async Task DisposeAsync()
		{

		}
	}
}
