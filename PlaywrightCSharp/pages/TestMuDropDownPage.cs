using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class TestMuDropDownPage
	{
		private IPage _page;

		public TestMuDropDownPage(IPage _page)
		{
			this._page = _page;
		}

		private ILocator _selectOptionLocator => _page.Locator("#select-demo");

		private ILocator _selectMultiOptionLocator => _page.Locator("#multi-select");

		private ILocator _selectedValue => _page.Locator(".selected-value");


		public ILocator getSelector()
		{
			return _selectOptionLocator;
		}

		public ILocator getMultiSelect()
		{
			return _selectMultiOptionLocator;
		}

		public ILocator getSelectedValue()
		{
			return _selectedValue;
		}


	}
}
