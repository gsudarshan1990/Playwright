using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Playwright;
using Playwright_Practice.pages;
using static Microsoft.Playwright.Assertions;

namespace Playwright_Practice.Tests
{
	public class CheckBoxDemoSecondTest : IClassFixture<PlaywrightFixture>
	{
		private IBrowser _browser = null!;

		private IBrowserContext _browserContext = null!;

		private IPage _page = null!;

		string url = "https://demoqa.com/checkbox";

		private CheckBoxPageDemoSecond _checkBoxDemoSecond = null!;

		public CheckBoxDemoSecondTest(PlaywrightFixture _fixture)
		{
			this._browser = _fixture._browser;
			
		}

		private async Task NavigateToDemoCheckBoxPage()
		{
			_browserContext = await _browser.NewContextAsync();
			_page = await _browserContext.NewPageAsync();
			await _page.GotoAsync(url);
			_checkBoxDemoSecond = new CheckBoxPageDemoSecond(_page);

		}

		[Fact]

		public async Task ClickHomeCheckBox()
		{
			await NavigateToDemoCheckBoxPage();
			await _checkBoxDemoSecond.getHomeCheckBox().CheckAsync();
			await Expect(_checkBoxDemoSecond.getCheckBoxItemsCount()).ToHaveCountAsync(17);
		}

		[Fact]
		public async Task ClickDownloadCheckBox()
		{
			await NavigateToDemoCheckBoxPage();
			await _checkBoxDemoSecond.getTreeSwitcher().ClickAsync();
			await _checkBoxDemoSecond.getCheckBoxDownloads().CheckAsync();
			await Expect(_checkBoxDemoSecond.getCheckBoxItemsCount()).ToHaveCountAsync(3);
			

		}

	}
}
