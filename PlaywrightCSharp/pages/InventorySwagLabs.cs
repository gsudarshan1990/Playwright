using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class InventorySwagLabs
	{
		private readonly ILocator _saucelabsbackpack = null!;

		private readonly ILocator _shoppingCartBadgeValue;

		private readonly ILocator _removeSauceLabsBackPackButton = null!;

		public InventorySwagLabs(IPage _page)
		{
			_saucelabsbackpack = _page.Locator("#add-to-cart-sauce-labs-backpack");

			_shoppingCartBadgeValue = _page.Locator(".shopping_cart_badge");

			_removeSauceLabsBackPackButton = _page.Locator("#remove-sauce-labs-backpack");
		}

		public void clickAddToCartSaucelabsBackPack()
		{
			_saucelabsbackpack.ClickAsync();
		}

		public Task<string> getCartBadgeValue()
		{
			
			return _shoppingCartBadgeValue.InnerTextAsync();
		}


		public ILocator getRemoveButton()
		{
			return _removeSauceLabsBackPackButton;
		}

	}
}
