using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class SelectPage
	{
		public IPage _page = null!;

		public SelectPage(IPage _page)
		{
			this._page = _page;
		}

		private ILocator _fruitSelector => _page.Locator("#fruits");

		private ILocator _programmingLanguageSelector => _page.Locator("#lang");

		private ILocator _countrySelector => _page.Locator("#country");

		private ILocator _fruitText => _page.Locator("p.subtitle").Nth(0);

		private ILocator _programText => _page.Locator("p.subtitle").Nth(1);

		public ILocator getFruitSelector()
		{
			return _fruitSelector;
		}

		public ILocator getProgrammingSelector()
		{
			return _programmingLanguageSelector;
		}

		public ILocator getCountrySelector()
		{
			return _countrySelector;
		}

		public ILocator getFruitText()
		{
			return _fruitText;
		}

		public ILocator getProgramText()
		{
			return _programText;
		}
	}
}
