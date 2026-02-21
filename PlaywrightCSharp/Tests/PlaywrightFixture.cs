using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.Tests
{
	public class PlaywrightFixture : IAsyncLifetime
	{
		public IPlaywright _playwright { get; private set; } = null!;

		private BrowserTypeLaunchOptions _launchOptions = null!;

		public IBrowser _browser { get; private set; } = null!;

		public async Task InitializeAsync()
		{
			_playwright = await Playwright.CreateAsync();
			_launchOptions = new BrowserTypeLaunchOptions { Headless = false };
			_browser = await _playwright.Chromium.LaunchAsync(_launchOptions);
		}

		public async Task DisposeAsync()
		{
			await _browser.DisposeAsync();
			_playwright.Dispose();
		}
	}
}
