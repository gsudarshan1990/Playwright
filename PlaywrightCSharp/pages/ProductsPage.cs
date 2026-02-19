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

		public async Task EnterSearchProduct(string data)
		{
			await _searchProductTextBox.FillAsync(data);
		}

		public async Task ClickSearch()
		{
			await _searchButton.ClickAsync();
		}

		public ILocator returnText()
		{
			return _searchedProductText;
		}


	}
}
