using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class CheckBoxPageDemoSecond
	{
		private IPage _page = null!;

		public CheckBoxPageDemoSecond(IPage _page)
		{
			this._page = _page;
		}

		private ILocator _homeCheckBox => _page.GetByRole(AriaRole.Checkbox, new() { Name = "Select Home" });

		private ILocator _DownloadsCheckBox => _page.GetByRole(AriaRole.Checkbox, new() { Name = "Select Downloads" });

		private ILocator _CheckBoxItemsCount => _page.Locator(".text-success");

		private ILocator _checkBoxTreeSwitcher => _page.Locator(".rc-tree-switcher");
		public ILocator getHomeCheckBox()
		{
			return _homeCheckBox;
		}

		public ILocator getCheckBoxItemsCount()
		{
			return _CheckBoxItemsCount;
		}

		public ILocator getTreeSwitcher()
		{
			return _checkBoxTreeSwitcher;
		}

		public ILocator getCheckBoxDownloads()
		{
			return _DownloadsCheckBox;
		}
	}
}
