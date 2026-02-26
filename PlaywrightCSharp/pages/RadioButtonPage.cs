using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class RadioButtonPage
	{
		private IPage _page = null!;

		public RadioButtonPage(IPage _page)
		{
			this._page = _page;
		}

		private ILocator _maleRadioButton => _page.GetByRole(AriaRole.Radio, new() { Name = "Male" }).Nth(0);

		private ILocator _femaleRadioButton => _page.GetByRole(AriaRole.Radio, new() { Name = "Female" }).Nth(0);

		private ILocator _getValueButton => _page.GetByRole(AriaRole.Button, new() { NameString = "Get value" , Exact = true });

		private ILocator _maleTextCheck => _page.GetByText("Radio button 'Male' is checked");

		private ILocator _femaleTextCheck => _page.GetByText("Radio button 'Female' is checked");

		private ILocator _radioNotChecked => _page.GetByText("Radio button is Not checked");
		public ILocator getMaleRadioButton()
		{
			return _maleRadioButton;
		}

		public ILocator getFemaleRadioButton()
		{
			return _femaleRadioButton;
		}

		public ILocator getValueButton()
		{
			return _getValueButton;
		}

		public ILocator getNotClickText()
		{
			return _radioNotChecked;
		}

		public ILocator getFemaleText()
		{
			return _femaleTextCheck;
		}

		public ILocator getMaleText()
		{
			return _maleTextCheck;
		}
	}
}
