using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

using Playwright_Practice.pages;
using static Microsoft.Playwright.Assertions;

namespace Playwright_Practice.Tests
{
	public class SelectPracticeTest : IClassFixture<PlaywrightFixture>
	{
		private IBrowser _browser = null!;

		private IBrowserContext _browserContext = null!;

		private IPage _page = null!;

		string url = "https://letcode.in/dropdowns";

		string url2 = "https://demoqa.com/select-menu";

		private SelectPage _selectPage = null!;

		private CustomSelectPage _customSelectPage = null!;

		public SelectPracticeTest(PlaywrightFixture _fixture)
		{
			this._browser = _fixture._browser;
		}

		[Fact]

		public async Task PracticeHTMLSelect()
		{
			_browserContext = await _browser.NewContextAsync();
			_page = await _browserContext.NewPageAsync();
			await _page.GotoAsync(url);
			_selectPage = new SelectPage(_page);
			await _selectPage.getFruitSelector().SelectOptionAsync("Banana");
			await Expect(_selectPage.getFruitText().GetByText("You have selected Banana")).ToBeVisibleAsync();
			await _selectPage.getProgrammingSelector().SelectOptionAsync("py");
			await Expect(_selectPage.getProgramText().GetByText("You have selected Python")).ToBeVisibleAsync();
			await _selectPage.getCountrySelector().SelectOptionAsync(new SelectOptionValue { Index = 8 });
			await Task.Delay(1000);			
		}

		[Fact]

		public async Task CustomSelect()
		{
			_browserContext = await _browser.NewContextAsync();
			_page = await _browserContext.NewPageAsync();
			await _page.GotoAsync(url2);
			_customSelectPage = new CustomSelectPage(_page);
			await _customSelectPage.getSelectValueDropDown().ClickAsync();
			await _customSelectPage.getSelectValueDropDown().GetByText("A root option").ClickAsync();
			await Expect(_customSelectPage.getSelectValueDropDown()).ToContainTextAsync("A root option");
			await _customSelectPage.getSelectOne().ClickAsync();
			await _customSelectPage.getSelectOne().GetByText("Ms.").ClickAsync();
			await Expect(_customSelectPage.getSelectOne()).ToContainTextAsync("Ms.");
		}
	}
}
