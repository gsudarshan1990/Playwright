using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class TheTimeOutExplanationPage
	{
		private ILocator _buttonTrigger = null!;

		private ILocator _dataAfterButtonTrigger = null!;
		
		public TheTimeOutExplanationPage(IPage _page)
		{
			_buttonTrigger = _page.Locator("#ajaxButton");

			_dataAfterButtonTrigger = _page.Locator(".bg-success");

		}

		public void ClickButton()
		{
			_buttonTrigger.ClickAsync();
		}

		public ILocator ReturnDataLocator()
		{
			return _dataAfterButtonTrigger;
		}

	}
}
