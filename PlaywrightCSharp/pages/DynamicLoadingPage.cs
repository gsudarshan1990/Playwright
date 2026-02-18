using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class DynamicLoadingPage
	{
		private  ILocator _startButton = null!;

		private ILocator _helloWorldText = null!;

		public DynamicLoadingPage(IPage _page)
		{
			_startButton = _page.GetByRole(AriaRole.Button, new() { Name = "Start" });
			_helloWorldText = _page.Locator("#finish h4");
		}

		public  async void clickStartButton()
		{
			await _startButton.ClickAsync();
		}

		public ILocator getHelloWorldLocator()
		{
			return _helloWorldText;
		}
	}
}
