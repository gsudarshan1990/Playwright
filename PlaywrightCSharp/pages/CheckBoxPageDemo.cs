using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class CheckBoxPageDemo
	{
		private IPage _page = null!;

		public CheckBoxPageDemo(IPage _page)
		{
			this._page = _page;

		}

		private ILocator _singleCheckBox => _page.GetByRole(AriaRole.Checkbox, new() { Name = "Click on check box" });

		private ILocator _singleCheckBoxCheckedAssert => _page.GetByText("Checked!");

		private ILocator _Option3DisabledCheckBox1 => _page.Locator("text=Option 3").Locator("input[type ='checkbox']").Nth(0);
		private ILocator _Option4DisabledCheckBox1 => _page.Locator("text=Option 4").Locator("input[type='checkbox']").Nth(0);

		private ILocator _Option1MultiCheckBox => _page.Locator("text=Option 1").Locator("input[type ='checkbox']").Nth(1);
		private ILocator _Option2MultiCheckBox => _page.Locator("text=Option 2").Locator("input[type='checkbox']").Nth(1);

		private ILocator _Option3MultiCheckBox => _page.Locator("text=Option 3").Locator("input[type ='checkbox']").Nth(1);
		private ILocator _Option4MultiCheckBox => _page.Locator("text=Option 4").Locator("input[type='checkbox']").Nth(1);

		private ILocator _checkAllButton => _page.GetByRole(AriaRole.Button, new() { NameString = "Check All" });


		public ILocator getSingleCheckBox()
		{
			return _singleCheckBox;
		}

		public ILocator getSingleCheckBoxCheckedAssert()
		{
			return _singleCheckBoxCheckedAssert;
		}

		public ILocator getDisabledOption1()
		{
			return _Option3DisabledCheckBox1;
		}

		public ILocator getDisabledOption2()
		{
			return _Option4DisabledCheckBox1;
		}

		public ILocator getOption1()
		{
			return _Option1MultiCheckBox;
		}

		public ILocator getOption2()
		{
			return _Option2MultiCheckBox;
		}

		public ILocator getOption3()
		{
			return _Option3MultiCheckBox;
		}

		public ILocator getOption4()
		{
			return _Option4MultiCheckBox;
		}

		public ILocator getCheckAll()
		{
			return _checkAllButton;
		}

	}
}
