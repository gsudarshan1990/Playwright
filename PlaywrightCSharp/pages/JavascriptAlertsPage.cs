using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class JavascriptAlertsPage
	{
		private IPage _page = null!;

		public JavascriptAlertsPage(IPage _page)
		{
			this._page = _page;
		}

		private ILocator _javaScriptAlertsClickMe => _page.GetByRole(AriaRole.Button, new() { NameString = "Click Me" }).Nth(0);

		private ILocator _confirmBoxClickMe => _page.GetByRole(AriaRole.Button, new() { NameString = "Click Me" }).Nth(1);

		private ILocator _promptBoxClickMe => _page.GetByRole(AriaRole.Button, new() { NameString = "Click Me" }).Nth(2);

		private ILocator _confirmText => _page.GetByText("You pressed OK!");

		private ILocator _cancelText => _page.GetByText("You pressed Cancel!");

		private ILocator _promptText => _page.GetByText("You have entered 'Govind' !");
	
		public ILocator getJavaScriptAlertsClick()
		{
			return _javaScriptAlertsClickMe;
		}

		public ILocator getConfirmBoxClick()
		{
			return _confirmBoxClickMe;
		}


		public ILocator getPromptBoxClick()
		{
			return _promptBoxClickMe;
		}

		public ILocator getConfirmText()
		{
			return _confirmText;
		}

		public ILocator getCancelText()
		{
			return _cancelText;
		}

		public ILocator getPromptText()
		{
			return _promptText;
		}

	}
}
