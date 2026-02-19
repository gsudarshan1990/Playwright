using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class AutomationExercisePage
	{
		private ILocator _image = null!;

		private ILocator _textFeatureItems = null!;

		private ILocator _womenAccordian = null!;

		private ILocator _dress = null!;

		private ILocator _tops = null!;

		private ILocator _saree = null!;

		public AutomationExercisePage(IPage _page)
		{
			_image = _page.Locator(".pull-left img");

			_textFeatureItems = _page.GetByRole(AriaRole.Heading, new() { NameString = "Features Items" });

			_womenAccordian = _page.GetByRole(AriaRole.Link, new() { Name = "Women" });

			_dress = _page.GetByRole(AriaRole.Link, new() { Name = "DRESS" });

			_tops = _page.GetByRole(AriaRole.Link, new() { Name = "TOPS" });

			_saree = _page.GetByRole(AriaRole.Link, new() { Name = "SAREE" });
		}


		public ILocator returnImage()
		{
			return _image;

		}

		public ILocator returnFeatureItems()
		{
			return _textFeatureItems;
		}

		public async Task clickWomen()
		{
			await _womenAccordian.ClickAsync();
		}

		public ILocator returnDress()
		{
			return _dress;
		}

		public ILocator returnTops()
		{
			return _tops;

		}

		public ILocator returnSaree()
		{
			return _saree;
		}
	}
}
