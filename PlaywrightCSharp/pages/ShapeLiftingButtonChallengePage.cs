using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class ShapeLiftingButtonChallengePage
	{
		private  ILocator _textbox = null!;

		private  ILocator _dynamicButton = null!;

		public ShapeLiftingButtonChallengePage(IPage _page)
		{
			_textbox = _page.Locator("#newButtonName");

			_dynamicButton = _page.Locator("#updatingButton");
		}

		public void EnterTextData(string data)
		{
			_textbox.FillAsync(data);
		}

		public void clickButton()
		{
			_dynamicButton.ClickAsync();
		}

		public ILocator returnButtonLocator()
		{
			return _dynamicButton;
		}
	}
}
