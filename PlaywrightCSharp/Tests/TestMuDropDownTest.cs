using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using Playwright_Practice.pages;

namespace Playwright_Practice.Tests
{
	public class TestMuDropDownTest : IClassFixture<PlaywrightFixture>
	{
		private IBrowser _browser = null!;

		private IBrowserContext _context = null!;

		private IPage _page = null!;

		string url = "https://www.testmuai.com/selenium-playground/select-dropdown-demo/";

		private TestMuDropDownPage _testMuDropDown = null!;
		public TestMuDropDownTest(PlaywrightFixture _fixture)
		{
			this._browser = _fixture._browser;
		}
		[Fact]
		public async Task SelectInTestMu()
		{
			_context = await _browser.NewContextAsync();
			_page = await _context.NewPageAsync();
			await _page.GotoAsync(url);
			_testMuDropDown = new TestMuDropDownPage(_page);
			await _testMuDropDown.getSelector().ClickAsync();
			await _testMuDropDown.getSelector().SelectOptionAsync("Thursday");
			await Expect(_testMuDropDown.getSelectedValue()).ToContainTextAsync("Thursday");
			await _testMuDropDown.getMultiSelect().SelectOptionAsync(new[] { "California", "Ohio", "Texas" });
			await Expect(_testMuDropDown.getMultiSelect()).ToHaveValuesAsync(new[] { "California", "Ohio", "Texas" });
			
		}

	}
}
