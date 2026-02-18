using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class CheckBoxPage
	{
		private ILocator _checkBox1 = null!;

		private ILocator _checkBox2 = null!;


		public CheckBoxPage(IPage _page)
		{
			_checkBox1 = _page.Locator("#checkboxes input:nth-child(1)");

			_checkBox2 = _page.Locator("#checkboxes input:nth-child(3)");
		}

		public ILocator getCheckBox1()
		{
			return _checkBox1;
		}

		public ILocator getCheckBox2()
		{
			return _checkBox2;
		}

	}
}
