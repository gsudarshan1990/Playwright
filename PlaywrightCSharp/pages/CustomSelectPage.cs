using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class CustomSelectPage
	{
		IPage _page = null!;

		public CustomSelectPage(IPage _page)
		{
			this._page = _page;
		}

		private ILocator _SelectValue => _page.Locator("#withOptGroup");

		private ILocator _SelectOne => _page.Locator("#selectOne");

		public ILocator getSelectValueDropDown()
		{
			return _SelectValue;
		}

		public ILocator getSelectOne()
		{
			return _SelectOne;
		}
	}
}
