using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class CartsPage
	{
		private IPage _page;

		public CartsPage(IPage _page)
		{
			this._page = _page;
		}
		private ILocator _tableRows => _page.Locator("#cart_info tbody tr");
		
		public ILocator returnTableRows()
		{
			return _tableRows;
		}
	}
}
