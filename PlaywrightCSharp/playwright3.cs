using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice
{	
	public class playwright3
	{
		private IBrowser _browser;

		private IPage _page;

		[Fact]
				
		public async Task LauchCricInfo()
		{
			//Launching the playwright object
			using var playwright = await Playwright.CreateAsync();

			//Launch Options

			var launchOptions = new BrowserTypeLaunchOptions { Headless = false };

			//Add launchoption to the browser 

			_browser = await playwright.Chromium.LaunchAsync(launchOptions);

			// Launch the page

			_page = await _browser.NewPageAsync();

			await _page.GotoAsync("https://www.espncricinfo.com/");

			await Task.Delay(2000);

		}

	}
}
