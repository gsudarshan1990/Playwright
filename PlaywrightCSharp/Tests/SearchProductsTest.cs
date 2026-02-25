using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using Playwright_Practice.pages;

namespace Playwright_Practice.Tests
{
	public class SearchProductsTest : IClassFixture<PlaywrightFixture>
	{
		private IBrowser _browser = null!;

		private IPage _page = null!;

		string url = "https://automationexercise.com/";

		private ILocator _products = null!;

		private ProductsPage _productsPage = null!;

		private CartsPage _cartsPage = null!;

		public SearchProductsTest(PlaywrightFixture _fixture)
		{
			this._browser = _fixture._browser;
		}

		[Fact]

		public async Task SearchProductAndAddToCart()
		{
			var _context = await _browser.NewContextAsync();
			_page = await _context.NewPageAsync();
			await _page.GotoAsync(url);
			_products = _page.GetByRole(AriaRole.Link, new() { Name = "Products" });
			await _products.ClickAsync();
			_productsPage = new ProductsPage(_page);
			await _productsPage.EnterAndSearchProduct("Jeans");
			await Expect(_productsPage.verifyJeans().Nth(0)).ToBeVisibleAsync();
			await _productsPage.ClickOneProducts();
			_cartsPage = new CartsPage(_page);
			await Expect(_cartsPage.returnTableRows()).ToHaveCountAsync(1);

		}

	}
}
