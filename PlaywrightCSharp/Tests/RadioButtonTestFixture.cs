using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using Playwright_Practice.pages;

namespace Playwright_Practice.Tests
{
	public class RadioButtonTestFixture:IClassFixture<PlaywrightFixture>
	{
		private IBrowser _browser = null!;

		private IBrowserContext _browserContext = null!;

		private IPage _page = null!;

		string url = "https://www.testmuai.com/selenium-playground/radiobutton-demo/";

		private RadioButtonPage _radioButtonPage = null!;
		public RadioButtonTestFixture(PlaywrightFixture _fixture)
		{
			this._browser = _fixture._browser;
		}

		[Fact]

		public async Task TestGenderUsingRadioButton()
		{
			_browserContext = await _browser.NewContextAsync();
			_page = await _browserContext.NewPageAsync();
			await _page.GotoAsync(url);
			_radioButtonPage = new RadioButtonPage(_page);
			await _radioButtonPage.getValueButton().ClickAsync();
			await Expect(_radioButtonPage.getNotClickText()).ToBeVisibleAsync();
			await Task.Delay(2000);
			await _radioButtonPage.getMaleRadioButton().ClickAsync();
			await _radioButtonPage.getValueButton().ClickAsync();
			await Expect(_radioButtonPage.getMaleText()).ToBeVisibleAsync();
			await Task.Delay(3000);
			await _radioButtonPage.getFemaleRadioButton().ClickAsync();
			await _radioButtonPage.getValueButton().ClickAsync();
			await Expect(_radioButtonPage.getFemaleText()).ToBeVisibleAsync();
			await Task.Delay(2000);

		}
	}
}
