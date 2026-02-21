using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice.pages
{
	public class ProductsPage
	{
		private IPage _page;

		public ProductsPage(IPage _page)
		{
			this._page = _page;
		}
		private ILocator _searchProductTextBox => _page.Locator("#search_product");
		private ILocator _searchButton =>  _page.Locator("#submit_search");

		private ILocator _searchedProductText => _page.GetByText("Searched Products");

		private ILocator _firstproduct => _page.Locator(".features_items .product-image-wrapper").Nth(2);

		private ILocator _firstProductAddToCart => _page.Locator(".overlay-content a").Nth(2);
		private ILocator _secondProduct => _page.Locator(".features_items .product-image-wrapper").Nth(4);
		
		private ILocator _SecondProductAddToCart => _page.Locator(".overlay-content a").Nth(4);

		private ILocator _ContinueShopping => _page.GetByRole(AriaRole.Button, new() { NameString = "Continue Shopping" });

		private ILocator _viewCartPage => _page.GetByRole(AriaRole.Link, new() { NameString = "View Cart" });

		private ILocator _verifyJeans => _page.Locator(".features_items .product-image-wrapper");
		public async Task EnterAndSearchProduct(string data)
		{
			await _searchProductTextBox.FillAsync(data);
			await _searchButton.ClickAsync();
		}

		public ILocator returnText()
		{
			return _searchedProductText;
		}

		public async Task ClickTwoProducts()
		{
			await _firstproduct.HoverAsync();
			await _firstProductAddToCart.ClickAsync();
			await _ContinueShopping.ClickAsync();
			await _secondProduct.HoverAsync();
			await _SecondProductAddToCart.ClickAsync();
			await _viewCartPage.ClickAsync();
			
		}

		
		public async Task ClickOneProducts()
		{
			await _firstproduct.HoverAsync();
			await _firstProductAddToCart.ClickAsync();
			await _viewCartPage.ClickAsync();
			
		}
					
		public ILocator verifyJeans()
		{
			return _verifyJeans;
		}

	}
}
