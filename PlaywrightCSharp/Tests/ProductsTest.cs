using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using Playwright_Practice.pages;

namespace Playwright_Practice.Tests
{
	public class ProductsTest : IClassFixture<PlaywrightFixture>
	{
		private readonly IBrowser _browser = null!;

		private  IPage _page = null!;

		private ILocator _products = null!;

		private ProductsPage _productsPage = null!;

		private CartsPage _cartsPage = null!;


		public ProductsTest(PlaywrightFixture _fixture)
		{
			_browser = _fixture._browser;
			
		}

		[Fact]

		public async Task AddProductsToTheCart()
		{
			var _context = await _browser.NewContextAsync();
			_page = await _context.NewPageAsync();
			_products = _page.GetByRole(AriaRole.Link, new() { Name = "Products" });
			await _page.GotoAsync("https://automationexercise.com/");
			await _products.ClickAsync();
			_productsPage = new ProductsPage(_page);
			await _productsPage.ClickTwoProducts();
			_cartsPage = new CartsPage(_page);
			await Expect(_cartsPage.returnTableRows()).ToHaveCountAsync(2);	
			

		}
	}
}
