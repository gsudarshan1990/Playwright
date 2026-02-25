using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using Playwright_Practice.pages;

namespace Playwright_Practice.Tests
{
	public class CheckBoxDemoTestUsingPlaywrightFixture : IClassFixture<PlaywrightFixture>
	{
		private IBrowser _browser = null!;

		private IBrowserContext _browserContext = null!;

		private IPage _page = null!;

		string url = "https://www.testmuai.com/selenium-playground/checkbox-demo/";

		private CheckBoxPageDemo _checkBoxPageDemo = null!;

		private ILocator _option3 = null!;

		private ILocator _option4 = null!;

		public CheckBoxDemoTestUsingPlaywrightFixture(PlaywrightFixture _fixture)
		{
			this._browser = _fixture._browser;
		}

		private async Task NavigateToCheckBoxPage()
		{
			_browserContext = await _browser.NewContextAsync();
			_page = await _browserContext.NewPageAsync();
			await _page.GotoAsync(url);
			_checkBoxPageDemo = new CheckBoxPageDemo(_page);
		}

		[Fact]

		public async Task DemoCheckBox()
		{
			await NavigateToCheckBoxPage();
			await _checkBoxPageDemo.getSingleCheckBox().CheckAsync(new LocatorCheckOptions { Force = true});
			await Expect(_checkBoxPageDemo.getSingleCheckBox()).ToBeCheckedAsync();
			await Expect(_checkBoxPageDemo.getSingleCheckBoxCheckedAssert()).ToBeVisibleAsync();
			
		}

		[Fact]

		public async Task ClickDisabledCheckBox()
		{
			await NavigateToCheckBoxPage();
			_option3 = _checkBoxPageDemo.getDisabledOption1();
			await _option3.EvaluateAsync("element  => element.removeAttribute('disabled')");
			await _option3.CheckAsync(new LocatorCheckOptions() { Force = true });
			await Expect(_option3).ToBeCheckedAsync(new LocatorAssertionsToBeCheckedOptions() { Checked = true });
			_option4 = _checkBoxPageDemo.getDisabledOption2();
			await _option4.EvaluateAsync("element  => element.removeAttribute('disabled')");
			await _option4.EvaluateAsync("element  => element.checked = true");
			await Expect(_option4).ToBeCheckedAsync(new LocatorAssertionsToBeCheckedOptions() { Checked = true});
			await Task.Delay(2000);		
			
		}

		[Fact]

		public async Task MultiCheckBox()
		{
			await NavigateToCheckBoxPage();
			ILocator _checkAllButton = _checkBoxPageDemo.getCheckAll();
			await _checkAllButton.EvaluateAsync("element => element.scrollIntoView({block : 'center'})");
			await _checkAllButton.HoverAsync();
			await _checkAllButton.ClickAsync(new LocatorClickOptions() { Force = true});
			await Expect(_checkBoxPageDemo.getOption1()).ToBeCheckedAsync();
			await Expect(_checkBoxPageDemo.getOption2()).ToBeCheckedAsync();
			await Expect(_checkBoxPageDemo.getOption3()).ToBeCheckedAsync();
			await Expect(_checkBoxPageDemo.getOption4()).ToBeCheckedAsync();
			await Task.Delay(2000);
		}
	}
}
