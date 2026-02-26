using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Playwright;
using Playwright_Practice.pages;
using static Microsoft.Playwright.Assertions;

namespace Playwright_Practice.Tests
{
	public  class JavaScriptAlertsTest : IClassFixture<PlaywrightFixture>
	{
		private IBrowser _browser = null!;

		private IBrowserContext _browserContext = null!;

		private IPage _page = null!;

		string url = "https://www.testmuai.com/selenium-playground/javascript-alert-box-demo/";

		private JavascriptAlertsPage _javaScriptAlertsPage = null!;

		public JavaScriptAlertsTest(PlaywrightFixture _fixture)
		{
			this._browser = _fixture._browser;
		}

		private async Task NavigateToAlertsPage()
		{
			_browserContext = await _browser.NewContextAsync();
			_page = await _browserContext.NewPageAsync();
			await _page.GotoAsync(url);
			_javaScriptAlertsPage = new JavascriptAlertsPage(_page);
		}

		[Fact]

		public async Task JavaScriptAlertsCheck()
		{
			await NavigateToAlertsPage();
			_page.Dialog += async (_, dialog) =>
			{
				await _page.WaitForTimeoutAsync(3000);
				await dialog.AcceptAsync();
			};
			await _javaScriptAlertsPage.getJavaScriptAlertsClick().ClickAsync();
			await _page.WaitForTimeoutAsync(2000);
		}

		[Fact]

		public async Task ConfirmBoxCancelAlert()
		{
			await NavigateToAlertsPage();
			_page.Dialog += async (_, dialog3) =>
			{
				await _page.WaitForTimeoutAsync(2000);
				await dialog3.DismissAsync();
			};
			await _javaScriptAlertsPage.getConfirmBoxClick().ClickAsync();
			await Expect(_javaScriptAlertsPage.getCancelText()).ToBeVisibleAsync();
			await Expect(_javaScriptAlertsPage.getCancelText()).ToHaveTextAsync("You pressed Cancel!");
		}

		[Fact]
		public async Task ConfirmBoxAcceptAlert()
		{
			await NavigateToAlertsPage();
			_page.Dialog += async (_, dialog2) =>
			{
				await _page.WaitForTimeoutAsync(3000);
				await dialog2.AcceptAsync();
			};
			await _javaScriptAlertsPage.getConfirmBoxClick().ClickAsync();
			await Expect(_javaScriptAlertsPage.getConfirmText()).ToBeVisibleAsync();
			await Expect(_javaScriptAlertsPage.getConfirmText()).ToHaveTextAsync("You pressed OK!");
			await _page.WaitForTimeoutAsync(1000);
		}

		[Fact]

		public async Task PromptBoxAlert()
		{
			await NavigateToAlertsPage();
			_page.Dialog += async (_, diaglog4) =>
			{
				await _page.WaitForTimeoutAsync(2000);
				await diaglog4.AcceptAsync("Govind");
			};
			ILocator _promptBox = _javaScriptAlertsPage.getPromptBoxClick();
			await _promptBox.HoverAsync();
			await _promptBox.ClickAsync(new() { Force = true });
			await Expect(_javaScriptAlertsPage.getPromptText()).ToBeVisibleAsync();
			await Expect(_javaScriptAlertsPage.getPromptText()).ToHaveTextAsync("You have entered 'Govind' !");
		}
	}
}
