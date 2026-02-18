using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class DynamicControlsPage
	{
		private ILocator _checkbox = null!;

		private ILocator _removeButton = null!;

		private ILocator _itsGone = null!;

		public DynamicControlsPage(IPage _page)
		{
			_checkbox = _page.Locator("#checkbox-example #checkbox");
			_removeButton = _page.Locator(".example #checkbox-example button");
			_itsGone = _page.Locator("#checkbox-example #message");
		}

		public void clickRemoveButton()
		{
			_removeButton.ClickAsync();
		}

		public ILocator getCheckBox()
		{
			return _checkbox;
		}

		public ILocator getItsGone()
		{
			return _itsGone;
		}

	}
}
