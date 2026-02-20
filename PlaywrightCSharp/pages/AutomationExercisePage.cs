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

		private ILocator _email = null!;

		private ILocator _emailSubmissionButton = null!;

		private ILocator _alertSuccess = null!;
		
		productsLink = _page.GetByRole(AriaRole.Link, new() { Name = "Products" });

		_contactUsLink = _page.GetByRole(AriaRole.Link, new() { Name = "Contact us" });

		_mensTshirt = _page.Locator(".features_items .product-image-wrapper").Nth(1);

		_mensTshirtAddToCart = _page.Locator(" .overlay-content > a").Nth(1);

		public AutomationExercisePage(IPage _page)
		{
			_image = _page.Locator(".pull-left img");

			_textFeatureItems = _page.GetByRole(AriaRole.Heading, new() { NameString = "Features Items" });

			_womenAccordian = _page.GetByRole(AriaRole.Link, new() { Name = "Women" });

			_dress = _page.GetByRole(AriaRole.Link, new() { Name = "DRESS" });

			_tops = _page.GetByRole(AriaRole.Link, new() { Name = "TOPS" });

			_saree = _page.GetByRole(AriaRole.Link, new() { Name = "SAREE" });

			_email = _page.Locator("#susbscribe_email");

			_emailSubmissionButton = _page.Locator("#subscribe");

			_alertSuccess = _page.Locator("#success-subscribe");	
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

		public async Task enterEmail(string emailid)
		{
			await _email.FillAsync(emailid);
		}

		public async Task ClickEmailSubscription()
		{
			await _emailSubmissionButton.ClickAsync();
		}

		public ILocator returnAlertMessageLocator()
		{
			return _alertSuccess;
		}

		public async Task ClickProducts()
{
	await _productsLink.ClickAsync();
}

public async Task ClickContactUs()
{
	await _contactUsLink.ClickAsync();
}

public async Task AddToCartProduct()
{
	await _mensTshirt.HoverAsync();
	await _mensTshirtAddToCart.ClickAsync();
}
	}
}
